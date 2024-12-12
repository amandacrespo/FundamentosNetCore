namespace FundamentosNetCore
{
    partial class Form7SumarNumerosString
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
            txtSumar = new TextBox();
            btnSumar = new Button();
            lblRes = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca numeros:";
            label1.Click += label1_Click;
            // 
            // txtSumar
            // 
            txtSumar.Location = new Point(21, 43);
            txtSumar.Name = "txtSumar";
            txtSumar.Size = new Size(125, 27);
            txtSumar.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(21, 76);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 29);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(21, 127);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 20);
            lblRes.TabIndex = 3;
            // 
            // Form7SumarNumerosString
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(lblRes);
            Controls.Add(btnSumar);
            Controls.Add(txtSumar);
            Controls.Add(label1);
            Name = "Form7SumarNumerosString";
            Text = "Form7SumarNumerosString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSumar;
        private Button btnSumar;
        private Label lblRes;
    }
}