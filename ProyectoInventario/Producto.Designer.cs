namespace ProyectoInventario
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.Label8 = new System.Windows.Forms.Label();
            this.txtbusprod = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.DGVproducto = new System.Windows.Forms.DataGridView();
            this.btninicio = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproducto)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(144, 471);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(458, 25);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "SISTEMA DE CONTROL DE INVENTARIOS ";
            // 
            // txtbusprod
            // 
            this.txtbusprod.Location = new System.Drawing.Point(113, 37);
            this.txtbusprod.MaxLength = 10;
            this.txtbusprod.Name = "txtbusprod";
            this.txtbusprod.Size = new System.Drawing.Size(290, 20);
            this.txtbusprod.TabIndex = 1;
            this.txtbusprod.TextChanged += new System.EventHandler(this.txtbusprod_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(42, 40);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(50, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Producto";
            // 
            // DGVproducto
            // 
            this.DGVproducto.AllowUserToAddRows = false;
            this.DGVproducto.AllowUserToDeleteRows = false;
            this.DGVproducto.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.DGVproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproducto.Location = new System.Drawing.Point(96, 319);
            this.DGVproducto.Name = "DGVproducto";
            this.DGVproducto.ReadOnly = true;
            this.DGVproducto.Size = new System.Drawing.Size(544, 136);
            this.DGVproducto.TabIndex = 28;
            this.DGVproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproducto_CellClick);
            this.DGVproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproducto_CellContentClick);
            // 
            // btninicio
            // 
            this.btninicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninicio.BackgroundImage")));
            this.btninicio.Location = new System.Drawing.Point(510, 126);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(64, 64);
            this.btninicio.TabIndex = 27;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtbusprod);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Location = new System.Drawing.Point(16, 212);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(695, 84);
            this.GroupBox2.TabIndex = 26;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Buscar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.Location = new System.Drawing.Point(440, 126);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 64);
            this.btnbuscar.TabIndex = 25;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.Location = new System.Drawing.Point(370, 126);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(64, 64);
            this.btneliminar.TabIndex = 24;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneditar.BackgroundImage")));
            this.btneditar.Location = new System.Drawing.Point(300, 126);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(64, 64);
            this.btneditar.TabIndex = 23;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.Location = new System.Drawing.Point(230, 126);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(64, 64);
            this.btnagregar.TabIndex = 22;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.Location = new System.Drawing.Point(160, 126);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(64, 64);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(404, 54);
            this.txtempresa.MaxLength = 100;
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(270, 20);
            this.txtempresa.TabIndex = 9;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(404, 28);
            this.txtprecio.MaxLength = 10;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(270, 20);
            this.txtprecio.TabIndex = 8;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(80, 55);
            this.txtcantidad.MaxLength = 5;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(234, 20);
            this.txtcantidad.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(80, 28);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(234, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(338, 57);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Empresa";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(338, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Precio";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Cantidad";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(17, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtempresa);
            this.GroupBox1.Controls.Add(this.txtprecio);
            this.GroupBox1.Controls.Add(this.txtcantidad);
            this.GroupBox1.Controls.Add(this.txtnombre);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(16, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(695, 96);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id";
            this.label5.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(50, 114);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 11;
            this.txtId.Visible = false;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(727, 517);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.DGVproducto);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Producto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.DGVproducto)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtbusprod;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView DGVproducto;
        internal System.Windows.Forms.Button btninicio;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnbuscar;
        internal System.Windows.Forms.Button btneliminar;
        internal System.Windows.Forms.Button btneditar;
        internal System.Windows.Forms.Button btnagregar;
        internal System.Windows.Forms.Button btnguardar;
        internal System.Windows.Forms.TextBox txtempresa;
        internal System.Windows.Forms.TextBox txtprecio;
        internal System.Windows.Forms.TextBox txtcantidad;
        internal System.Windows.Forms.TextBox txtnombre;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
    }
}