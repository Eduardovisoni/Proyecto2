namespace OrientadorEducativoIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNivelEducativo = new System.Windows.Forms.TextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNivelAcademico = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnGuardarPerfil = new System.Windows.Forms.Button();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.btnConsultarIA = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.RichTextBox();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(124, 53);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(288, 22);
            this.txtEdad.TabIndex = 1;
            // 
            // txtNivelEducativo
            // 
            this.txtNivelEducativo.Location = new System.Drawing.Point(194, 89);
            this.txtNivelEducativo.Name = "txtNivelEducativo";
            this.txtNivelEducativo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNivelEducativo.Size = new System.Drawing.Size(218, 22);
            this.txtNivelEducativo.TabIndex = 2;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(529, 53);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPregunta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPregunta.Size = new System.Drawing.Size(404, 112);
            this.txtPregunta.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Escribe tu nombre:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(14, 56);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(104, 16);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Escribe tu edad:";
            // 
            // lblNivelAcademico
            // 
            this.lblNivelAcademico.AutoSize = true;
            this.lblNivelAcademico.Location = new System.Drawing.Point(12, 92);
            this.lblNivelAcademico.Name = "lblNivelAcademico";
            this.lblNivelAcademico.Size = new System.Drawing.Size(171, 16);
            this.lblNivelAcademico.TabIndex = 6;
            this.lblNivelAcademico.Text = "Escribe tu nivel academico:";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(526, 27);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(346, 16);
            this.lblPregunta.TabIndex = 7;
            this.lblPregunta.Text = "Escribe tus intereses educativos o vocacionales!";
            // 
            // btnGuardarPerfil
            // 
            this.btnGuardarPerfil.Location = new System.Drawing.Point(262, 177);
            this.btnGuardarPerfil.Name = "btnGuardarPerfil";
            this.btnGuardarPerfil.Size = new System.Drawing.Size(263, 28);
            this.btnGuardarPerfil.TabIndex = 8;
            this.btnGuardarPerfil.Text = "Guardar Perfil";
            this.btnGuardarPerfil.UseVisualStyleBackColor = true;
            this.btnGuardarPerfil.Click += new System.EventHandler(this.btnGuardarPerfil_Click);
            // 
            // txtIntereses
            // 
            this.txtIntereses.Location = new System.Drawing.Point(155, 125);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(257, 22);
            this.txtIntereses.TabIndex = 9;
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(14, 128);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(134, 16);
            this.lblIntereses.TabIndex = 10;
            this.lblIntereses.Text = "Escribe tus intereses:";
            // 
            // btnConsultarIA
            // 
            this.btnConsultarIA.Location = new System.Drawing.Point(616, 171);
            this.btnConsultarIA.Name = "btnConsultarIA";
            this.btnConsultarIA.Size = new System.Drawing.Size(220, 41);
            this.btnConsultarIA.TabIndex = 11;
            this.btnConsultarIA.Text = "Consultar";
            this.btnConsultarIA.UseVisualStyleBackColor = true;
            this.btnConsultarIA.Click += new System.EventHandler(this.btnConsultarIA_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.Location = new System.Drawing.Point(262, 229);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(261, 31);
            this.btnExportarPDF.TabIndex = 15;
            this.btnExportarPDF.Text = "Exportar consulta a PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(529, 233);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(400, 264);
            this.txtRespuesta.TabIndex = 16;
            this.txtRespuesta.Text = "";
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaConsulta.Location = new System.Drawing.Point(262, 266);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(261, 33);
            this.btnNuevaConsulta.TabIndex = 17;
            this.btnNuevaConsulta.Text = "Nueva consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 528);
            this.Controls.Add(this.btnNuevaConsulta);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnConsultarIA);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.btnGuardarPerfil);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblNivelAcademico);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.txtNivelEducativo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNivelEducativo;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNivelAcademico;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnGuardarPerfil;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Button btnConsultarIA;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.RichTextBox txtRespuesta;
        private System.Windows.Forms.Button btnNuevaConsulta;
    }
}

