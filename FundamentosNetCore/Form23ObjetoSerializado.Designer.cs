namespace FundamentosNetCore
{
    partial class Form23ObjetoSerializado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNom = new TextBox();
            txtRaz = new TextBox();
            label2 = new Label();
            txtYears = new TextBox();
            label3 = new Label();
            btnLeer = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(12, 27);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 1;
            // 
            // txtRaz
            // 
            txtRaz.Location = new Point(12, 82);
            txtRaz.Name = "txtRaz";
            txtRaz.Size = new Size(100, 23);
            txtRaz.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtYears
            // 
            txtYears.Location = new Point(12, 141);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(100, 23);
            txtYears.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Años";
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(135, 53);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(92, 23);
            btnLeer.TabIndex = 6;
            btnLeer.Text = "Leer dato";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(135, 113);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar dato";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form23ObjetoSerializado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 179);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(txtYears);
            Controls.Add(label3);
            Controls.Add(txtRaz);
            Controls.Add(label2);
            Controls.Add(txtNom);
            Controls.Add(label1);
            Name = "Form23ObjetoSerializado";
            Text = "Form23ObjetoSerializado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNom;
        private TextBox txtRaz;
        private Label label2;
        private TextBox txtYears;
        private Label label3;
        private Button btnLeer;
        private Button btnGuardar;
    }
}