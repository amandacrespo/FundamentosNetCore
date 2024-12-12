namespace FundamentosNetCore
{
    partial class Form12CollecionMultiple
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
            lblIndexSeleccionado = new Label();
            lblItemSeleccionado = new Label();
            btnBorrar = new Button();
            btnDelet = new Button();
            btnInsert = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(171, 391);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(50, 20);
            lblIndexSeleccionado.TabIndex = 17;
            lblIndexSeleccionado.Text = "label4";
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(171, 357);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(50, 20);
            lblItemSeleccionado.TabIndex = 16;
            lblItemSeleccionado.Text = "label3";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(445, 166);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(445, 131);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(94, 29);
            btnDelet.TabIndex = 14;
            btnDelet.Text = "Eliminar";
            btnDelet.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(445, 96);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(445, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 40);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 11;
            label2.Text = "Nuevo elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(171, 63);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(231, 264);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // Form12CollecionMultiple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnBorrar);
            Controls.Add(btnDelet);
            Controls.Add(btnInsert);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form12CollecionMultiple";
            Text = "Form12CollecionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndexSeleccionado;
        private Label lblItemSeleccionado;
        private Button btnBorrar;
        private Button btnDelet;
        private Button btnInsert;
        private TextBox textBox1;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
    }
}