namespace FundamentosNetCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRespuesta = new Label();
            txtNombre = new TextBox();
            btnEnviar = new Button();
            lblRes = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(27, 19);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(54, 15);
            lblRespuesta.TabIndex = 1;
            lblRespuesta.Text = "Nombre:";
            lblRespuesta.Click += lblRespuesta_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(27, 66);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(28, 106);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 15);
            lblRes.TabIndex = 4;
            lblRes.Click += label1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(108, 66);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reiniciar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(lblRes);
            Controls.Add(btnEnviar);
            Controls.Add(txtNombre);
            Controls.Add(lblRespuesta);
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRespuesta;
        private TextBox txtNombre;
        private Button btnEnviar;
        private Label lblRes;
        private Button btnReset;
    }
}
