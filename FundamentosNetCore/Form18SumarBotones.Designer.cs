namespace FundamentosNetCore
{
    partial class Form18SumarBotones
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
            textBox1 = new TextBox();
            btnIniciar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelButtons = new Panel();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Suma";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(162, 13);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(2, 21);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "but";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(83, 21);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "but";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(164, 21);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "but";
            button4.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button4);
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Location = new Point(11, 47);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(247, 60);
            panelButtons.TabIndex = 6;
            // 
            // Form18SumarBotones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 115);
            Controls.Add(panelButtons);
            Controls.Add(btnIniciar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form18SumarBotones";
            Text = "Form18SumarBotones";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnIniciar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelButtons;
    }
}