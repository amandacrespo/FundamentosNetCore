namespace FundamentosNetCore
{
    partial class Form24ColeccionSerializada
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
            lstMascotas = new ListBox();
            label3 = new Label();
            btnSave = new Button();
            btnRead = new Button();
            btnNew = new Button();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtYears = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(158, 27);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(148, 244);
            lstMascotas.TabIndex = 17;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 16;
            label3.Text = "Mascotas";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(12, 205);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 14;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 176);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 74);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 11;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // txtYears
            // 
            txtYears.Location = new Point(12, 123);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(100, 23);
            txtYears.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 18;
            label4.Text = "Años";
            // 
            // Form24ColeccionSerializada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 282);
            Controls.Add(txtYears);
            Controls.Add(label4);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(btnRead);
            Controls.Add(btnNew);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form24ColeccionSerializada";
            Text = "Form24ColeccionSerializada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMascotas;
        private Label label3;
        private Button btnSave;
        private Button btnRead;
        private Button btnNew;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtYears;
        private Label label4;
    }
}