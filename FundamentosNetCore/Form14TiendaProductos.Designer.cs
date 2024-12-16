namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
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
            txtAgregar = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            label2 = new Label();
            lstTienda = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(12, 27);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(130, 23);
            txtAgregar.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 56);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 85);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(12, 114);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(75, 23);
            btnBorrarTodo.TabIndex = 4;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 9);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Tienda:";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(181, 27);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(120, 184);
            lstTienda.TabIndex = 6;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(322, 94);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 7;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(322, 123);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(421, 27);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(120, 184);
            lstAlmacen.TabIndex = 10;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Almacén:";
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(557, 94);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(557, 123);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 228);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstAlmacen);
            Controls.Add(label3);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstTienda);
            Controls.Add(label2);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtAgregar);
            Controls.Add(label1);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAgregar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label label2;
        private ListBox lstTienda;
        private Button btnSeleccion;
        private Button btnTodos;
        private ListBox lstAlmacen;
        private Label label3;
        private Button btnSubir;
        private Button btnBajar;
    }
}