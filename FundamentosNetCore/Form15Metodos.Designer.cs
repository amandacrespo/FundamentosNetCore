namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            txtNum = new TextBox();
            lblRes = new Label();
            btnDobleVal = new Button();
            btnDobleRef = new Button();
            btnObjRef = new Button();
            label2 = new Label();
            label3 = new Label();
            lblRaton = new Label();
            txtSoloNum = new TextBox();
            txtSoloLet = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(12, 27);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(12, 70);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(38, 15);
            lblRes.TabIndex = 2;
            lblRes.Text = "lblRes";
            lblRes.Click += label2_Click;
            // 
            // btnDobleVal
            // 
            btnDobleVal.Location = new Point(163, 12);
            btnDobleVal.Name = "btnDobleVal";
            btnDobleVal.Size = new Size(114, 23);
            btnDobleVal.TabIndex = 3;
            btnDobleVal.Text = "Doble valor";
            btnDobleVal.UseVisualStyleBackColor = true;
            btnDobleVal.Click += btnDobleVal_Click;
            // 
            // btnDobleRef
            // 
            btnDobleRef.Location = new Point(163, 41);
            btnDobleRef.Name = "btnDobleRef";
            btnDobleRef.Size = new Size(114, 23);
            btnDobleRef.TabIndex = 4;
            btnDobleRef.Text = "Doble refencia";
            btnDobleRef.UseVisualStyleBackColor = true;
            btnDobleRef.Click += btnDobleRef_Click;
            // 
            // btnObjRef
            // 
            btnObjRef.Location = new Point(163, 70);
            btnObjRef.Name = "btnObjRef";
            btnObjRef.Size = new Size(114, 23);
            btnObjRef.TabIndex = 5;
            btnObjRef.Text = "Objeto referencia";
            btnObjRef.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Solo números:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 7;
            label3.Text = "Solo letras:";
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.Info;
            lblRaton.Location = new Point(253, 138);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(100, 166);
            lblRaton.TabIndex = 8;
            lblRaton.Text = "lblRaton";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtSoloNum
            // 
            txtSoloNum.Location = new Point(119, 138);
            txtSoloNum.Name = "txtSoloNum";
            txtSoloNum.Size = new Size(100, 23);
            txtSoloNum.TabIndex = 9;
            txtSoloNum.KeyUp += txtSoloNum_KeyUp;
            // 
            // txtSoloLet
            // 
            txtSoloLet.Location = new Point(119, 167);
            txtSoloLet.Name = "txtSoloLet";
            txtSoloLet.Size = new Size(100, 23);
            txtSoloLet.TabIndex = 10;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 317);
            Controls.Add(txtSoloLet);
            Controls.Add(txtSoloNum);
            Controls.Add(lblRaton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnObjRef);
            Controls.Add(btnDobleRef);
            Controls.Add(btnDobleVal);
            Controls.Add(lblRes);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Label lblRes;
        private Button btnDobleVal;
        private Button btnDobleRef;
        private Button btnObjRef;
        private Label label2;
        private Label label3;
        private Label lblRaton;
        private TextBox txtSoloNum;
        private TextBox txtSoloLet;
    }
}