using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OrientadorEducativoIA
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=DESKTOP-ICSDIP0\\SQLEXPRESS01;Database=OrientacionEducativaDB;Trusted_Connection=True;";
        private int usuarioId;

        public Form1()
        {
            InitializeComponent();
            btnConsultarIA.Enabled = false;
            btnExportarPDF.Enabled = false;
            btnNuevaConsulta.Enabled = false;
        }

        private void btnGuardarPerfil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtNivelEducativo.Text) ||
                string.IsNullOrWhiteSpace(txtIntereses.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar el perfil.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una edad válida (número entero mayor que cero).", "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Usuarios (Nombre, Edad, NivelEducativo, Intereses) OUTPUT INSERTED.Id VALUES (@n, @e, @ne, @i)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@e", edad);
                    cmd.Parameters.AddWithValue("@ne", txtNivelEducativo.Text.Trim());
                    cmd.Parameters.AddWithValue("@i", txtIntereses.Text.Trim());
                    conn.Open();
                    usuarioId = (int)cmd.ExecuteScalar();
                    MessageBox.Show("Perfil guardado exitosamente.");
                    btnConsultarIA.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el perfil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private async void btnConsultarIA_Click(object sender, EventArgs e)
        {
            string pregunta = txtPregunta.Text;
            string respuesta = await ConsultarOpenAI(pregunta);
            txtRespuesta.Text = respuesta;
            GuardarConsulta(pregunta, respuesta);
            btnNuevaConsulta.Enabled = true;
            btnExportarPDF.Enabled = true;
        }

        private async Task<string> ConsultarOpenAI(string pregunta)
        {
            string apiKey = "Api Key";
            string endpoint = "https://api.openai.com/v1/chat/completions";

            string nombre = txtNombre.Text.Trim();

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            
            var requestBody = new
            {
                model = "o4-mini",
                messages = new[]
                {
                    new { role = "system", content = $"Eres un orientador vocacional especializado en ayudar a estudiantes guatemaltecos como {nombre} en el departamento de Jutiapa, recaba el maximo de informacion de Jutiapa, y si encuentras informacion en general de guatemala muestrala para no ser tan limitada la informacion. Tu tarea es guiarlos para descubrir opciones de carrera profesional basándote en sus intereses, habilidades y nivel educativo. Siempre debes mencionar el nombre del estudiante ({nombre}) en tus respuestas, haciéndolas personalizadas y empáticas. Solo debes responder preguntas relacionadas con orientación vocacional. Si {nombre} te hace preguntas fuera de ese tema, responde amablemente que tu función es únicamente brindar orientación vocacional. Quiero que la respuesta me la des ordenada, no solo muestres un parrafo entero, no me refiero solamente a puntos y comas, me refiero a saltos de lineas, y que coloques el resultado en lista si, por ejemplo, lista de lugares donde estudiar o trabajar" },
                    new { role = "user", content = pregunta }
                }
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(endpoint, content);
            var responseJson = await response.Content.ReadAsStringAsync();

            dynamic result = JsonConvert.DeserializeObject(responseJson);
            return result.choices[0].message.content;
        }

        private void GuardarConsulta(string pregunta, string respuesta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HistorialConsultas (UsuarioId, Pregunta, Respuesta) VALUES (@uid, @p, @r)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", usuarioId);
                cmd.Parameters.AddWithValue("@p", pregunta);
                cmd.Parameters.AddWithValue("@r", respuesta);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            string contenido = txtRespuesta.Text;

            if (string.IsNullOrWhiteSpace(contenido))
            {
                MessageBox.Show("No hay contenido para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.Title = "Guardar respuesta como PDF";
                sfd.FileName = "OrientacionVocacional.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportarRespuestaAPDF(contenido, sfd.FileName);
                }
            }
        }

        private void ExportarRespuestaAPDF(string contenido, string nombreArchivo)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 50, 50, 50, 50);

            using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();

                iTextSharp.text.Font font = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);

                iTextSharp.text.Paragraph parrafo = new iTextSharp.text.Paragraph(contenido, font);
                parrafo.Alignment = Element.ALIGN_LEFT;

                doc.Add(parrafo);
                doc.Close();
                writer.Close();
            }

            MessageBox.Show("PDF exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            txtPregunta.Text = string.Empty;
            txtRespuesta.Text = string.Empty;
        }
        private void VerificarCamposParaLimpiar()
        {
            if (string.IsNullOrWhiteSpace(txtPregunta.Text) && string.IsNullOrWhiteSpace(txtRespuesta.Text))
            {
                MessageBox.Show("No hay texto para borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnNuevaConsulta.Enabled = !string.IsNullOrWhiteSpace(txtPregunta.Text) || !string.IsNullOrWhiteSpace(txtRespuesta.Text);
        }

    }
}
