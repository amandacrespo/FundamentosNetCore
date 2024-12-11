namespace FundamentosNetCore
{
    partial class FormDateTime
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
            txtFechaAct = new TextBox();
            chkCambiar = new CheckBox();
            groupBox1 = new GroupBox();
            btnIncrementar = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            rbAnios = new RadioButton();
            rbMeses = new RadioButton();
            rbDias = new RadioButton();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaAct
            // 
            txtFechaAct.Location = new Point(24, 44);
            txtFechaAct.Name = "txtFechaAct";
            txtFechaAct.Size = new Size(348, 23);
            txtFechaAct.TabIndex = 1;
            // 
            // chkCambiar
            // 
            chkCambiar.AutoSize = true;
            chkCambiar.Location = new Point(24, 73);
            chkCambiar.Name = "chkCambiar";
            chkCambiar.Size = new Size(149, 19);
            chkCambiar.TabIndex = 2;
            chkCambiar.Text = "Cambiar formato fecha";
            chkCambiar.UseVisualStyleBackColor = true;
            chkCambiar.CheckedChanged += chkCambiar_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rbAnios);
            groupBox1.Controls.Add(rbMeses);
            groupBox1.Controls.Add(rbDias);
            groupBox1.Location = new Point(24, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 111);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(259, 51);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(75, 23);
            btnIncrementar.TabIndex = 5;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(153, 51);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            label2.Click += label2_Click;
            // 
            // rbAnios
            // 
            rbAnios.AutoSize = true;
            rbAnios.Location = new Point(10, 76);
            rbAnios.Name = "rbAnios";
            rbAnios.Size = new Size(52, 19);
            rbAnios.TabIndex = 2;
            rbAnios.TabStop = true;
            rbAnios.Text = "Años";
            rbAnios.UseVisualStyleBackColor = true;
            // 
            // rbMeses
            // 
            rbMeses.AutoSize = true;
            rbMeses.Location = new Point(10, 51);
            rbMeses.Name = "rbMeses";
            rbMeses.Size = new Size(58, 19);
            rbMeses.TabIndex = 1;
            rbMeses.TabStop = true;
            rbMeses.Text = "Meses";
            rbMeses.UseVisualStyleBackColor = true;
            // 
            // rbDias
            // 
            rbDias.AutoSize = true;
            rbDias.Location = new Point(10, 26);
            rbDias.Name = "rbDias";
            rbDias.Size = new Size(47, 19);
            rbDias.TabIndex = 0;
            rbDias.TabStop = true;
            rbDias.Text = "Dias";
            rbDias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 246);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(24, 264);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(348, 23);
            txtNuevaFecha.TabIndex = 7;
            // 
            // FormDateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 317);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiar);
            Controls.Add(txtFechaAct);
            Controls.Add(label1);
            Name = "FormDateTime";
            Text = "FormDateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaAct;
        private CheckBox chkCambiar;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton rbAnios;
        private RadioButton rbMeses;
        private RadioButton rbDias;
        private Button btnIncrementar;
        private TextBox txtIncremento;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}