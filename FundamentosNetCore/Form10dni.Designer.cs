namespace FundamentosNetCore
{
    partial class Form10dni
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
            txtDni = new TextBox();
            btnValidar = new Button();
            lblRes = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(12, 32);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(273, 27);
            txtDni.TabIndex = 1;
            txtDni.Text = "12345678X";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(12, 65);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(94, 29);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(12, 111);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 20);
            lblRes.TabIndex = 3;
            // 
            // Form10dni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 204);
            Controls.Add(lblRes);
            Controls.Add(btnValidar);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Name = "Form10dni";
            Text = "Form10dni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private Button btnValidar;
        private Label lblRes;
    }
}