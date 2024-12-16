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
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(150, 293);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(93, 15);
            lblIndexSeleccionado.TabIndex = 17;
            lblIndexSeleccionado.Text = "lblIndexSelected";
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(150, 268);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(90, 15);
            lblItemSeleccionado.TabIndex = 16;
            lblItemSeleccionado.Text = "lbltemsSelected";
            lblItemSeleccionado.Click += lblItemSeleccionado_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(389, 124);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(82, 22);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(389, 98);
            btnDelet.Margin = new Padding(3, 2, 3, 2);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(82, 22);
            btnDelet.TabIndex = 14;
            btnDelet.Text = "Eliminar";
            btnDelet.UseVisualStyleBackColor = true;
            btnDelet.Click += btnDelet_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(389, 72);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(82, 22);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(389, 47);
            txtNuevoElemento.Margin = new Padding(3, 2, 3, 2);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(162, 23);
            txtNuevoElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 30);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Nuevo elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(150, 47);
            lstElementos.Margin = new Padding(3, 2, 3, 2);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(203, 199);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(389, 151);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(95, 23);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form12CollecionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnBorrar);
            Controls.Add(btnDelet);
            Controls.Add(btnInsert);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtNuevoElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Button btnSeleccionados;
    }
}