namespace FundamentosNetCore
{
    partial class Form9ValidarISBN
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
            txtISBN = new TextBox();
            btnValidar = new Button();
            lblRes = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(12, 32);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(271, 27);
            txtISBN.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(69, 65);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(151, 29);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(12, 113);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 20);
            lblRes.TabIndex = 3;
            lblRes.Click += lblRes_Click;
            // 
            // Form9ValidarISBN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 159);
            Controls.Add(lblRes);
            Controls.Add(btnValidar);
            Controls.Add(txtISBN);
            Controls.Add(label1);
            Name = "Form9ValidarISBN";
            Text = "Form9ValidarISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtISBN;
        private Button btnValidar;
        private Label lblRes;
    }
}