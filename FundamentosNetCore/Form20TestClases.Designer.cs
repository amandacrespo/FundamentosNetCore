﻿namespace FundamentosNetCore
{
    partial class Form20TestClases
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
            lstClases = new ListBox();
            btnPersona = new Button();
            btnNewEmp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Clases";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(12, 27);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(478, 289);
            lstClases.TabIndex = 1;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(12, 322);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(75, 23);
            btnPersona.TabIndex = 2;
            btnPersona.Text = "Persona";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // btnNewEmp
            // 
            btnNewEmp.Location = new Point(93, 322);
            btnNewEmp.Name = "btnNewEmp";
            btnNewEmp.Size = new Size(75, 23);
            btnNewEmp.TabIndex = 3;
            btnNewEmp.Text = "Empleado";
            btnNewEmp.UseVisualStyleBackColor = true;
            btnNewEmp.Click += btnNewEmp_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 365);
            Controls.Add(btnNewEmp);
            Controls.Add(btnPersona);
            Controls.Add(lstClases);
            Controls.Add(label1);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstClases;
        private Button btnPersona;
        private Button btnNewEmp;
    }
}