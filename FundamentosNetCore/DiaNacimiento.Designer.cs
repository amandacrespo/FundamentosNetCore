namespace FundamentosNetCore
{
    partial class DiaNacimiento
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
            txtDia = new TextBox();
            label2 = new Label();
            txtMes = new TextBox();
            label3 = new Label();
            txtAnio = new TextBox();
            btnCalcular = new Button();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Dia";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(25, 40);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(25, 99);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 137);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Anio";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(25, 155);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(174, 73);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(162, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular dia nacimiento";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(174, 107);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(0, 15);
            lblRespuesta.TabIndex = 7;
            // 
            // DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 211);
            Controls.Add(lblRespuesta);
            Controls.Add(btnCalcular);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(txtMes);
            Controls.Add(label2);
            Controls.Add(txtDia);
            Controls.Add(label1);
            Name = "DiaNacimiento";
            Text = "DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDia;
        private Label label2;
        private TextBox txtMes;
        private Label label3;
        private TextBox txtAnio;
        private Button btnCalcular;
        private Label lblRespuesta;
    }
}