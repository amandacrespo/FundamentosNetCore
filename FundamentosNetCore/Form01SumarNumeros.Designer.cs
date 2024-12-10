namespace FundamentosNetCore
{
    partial class Form01SumarNumeros
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
            lblN1 = new Label();
            lblN2 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            btnSum = new Button();
            lblRes = new Label();
            SuspendLayout();
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(28, 28);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(25, 15);
            lblN1.TabIndex = 0;
            lblN1.Text = "N1:";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(28, 82);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(25, 15);
            lblN2.TabIndex = 1;
            lblN2.Text = "N2:";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(28, 46);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 2;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(28, 100);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 3;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(28, 146);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(75, 23);
            btnSum.TabIndex = 4;
            btnSum.Text = "Sumar";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(30, 191);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 15);
            lblRes.TabIndex = 5;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRes);
            Controls.Add(btnSum);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblN1;
        private Label lblN2;
        private TextBox txtN1;
        private TextBox txtN2;
        private Button btnSum;
        private Label lblRes;
    }
}