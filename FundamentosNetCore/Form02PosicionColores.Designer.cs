namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            label2 = new Label();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            btnMov = new Button();
            label3 = new Label();
            txtRojo = new TextBox();
            label4 = new Label();
            txtVerde = new TextBox();
            label5 = new Label();
            txtAzul = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Posición X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Posición Y:";
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(97, 23);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(97, 61);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 3;
            // 
            // btnMov
            // 
            btnMov.Location = new Point(122, 101);
            btnMov.Name = "btnMov";
            btnMov.Size = new Size(75, 23);
            btnMov.TabIndex = 4;
            btnMov.Text = "Mover";
            btnMov.UseVisualStyleBackColor = true;
            btnMov.Click += btnMov_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 26);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Rojo:";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(325, 23);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 64);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Verde:";
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(325, 61);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 101);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Azul:";
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(325, 98);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(350, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Cambiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 182);
            Controls.Add(button1);
            Controls.Add(txtAzul);
            Controls.Add(label5);
            Controls.Add(txtVerde);
            Controls.Add(label4);
            Controls.Add(txtRojo);
            Controls.Add(label3);
            Controls.Add(btnMov);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private Button btnMov;
        private Label label3;
        private TextBox txtRojo;
        private Label label4;
        private TextBox txtVerde;
        private Label label5;
        private TextBox txtAzul;
        private Button button1;
    }
}