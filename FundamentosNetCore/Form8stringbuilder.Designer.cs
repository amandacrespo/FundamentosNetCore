namespace FundamentosNetCore
{
    partial class Form8stringbuilder
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
            txtTexto = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            lblTiempo = new Label();
            lblTiempoo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Copie el texto para trabajar";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(12, 32);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(503, 244);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 291);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 2;
            button1.Text = "Invertir string";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 291);
            button2.Name = "button2";
            button2.Size = new Size(160, 29);
            button2.TabIndex = 3;
            button2.Text = "Invertir stringBuilder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(259, 291);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 20);
            lblTiempo.TabIndex = 4;
            // 
            // lblTiempoo
            // 
            lblTiempoo.AutoSize = true;
            lblTiempoo.Location = new Point(12, 332);
            lblTiempoo.Name = "lblTiempoo";
            lblTiempoo.Size = new Size(0, 20);
            lblTiempoo.TabIndex = 5;
            // 
            // Form8stringbuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 416);
            Controls.Add(lblTiempoo);
            Controls.Add(lblTiempo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Name = "Form8stringbuilder";
            Text = "Form8stringbuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Button button1;
        private Button button2;
        private Label lblTiempo;
        private Label lblTiempoo;
    }
}