namespace ProyectoInventario
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            this.Label8 = new System.Windows.Forms.Label();
            this.txtbusprov = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtcod_postal = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.DGVproveedor = new System.Windows.Forms.DataGridView();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproveedor)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(145, 474);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(458, 25);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "SISTEMA DE CONTROL DE INVENTARIOS ";
            // 
            // txtbusprov
            // 
            this.txtbusprov.Location = new System.Drawing.Point(113, 37);
            this.txtbusprov.Name = "txtbusprov";
            this.txtbusprov.Size = new System.Drawing.Size(290, 20);
            this.txtbusprov.TabIndex = 1;
            this.txtbusprov.TextChanged += new System.EventHandler(this.txtbusprov_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(42, 40);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(56, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Proveedor";
            // 
            // btninicio
            // 
            this.btninicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninicio.BackgroundImage")));
            this.btninicio.Location = new System.Drawing.Point(507, 136);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(64, 64);
            this.btninicio.TabIndex = 27;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtbusprov);
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
            this.btnbuscar.Location = new System.Drawing.Point(437, 136);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 64);
            this.btnbuscar.TabIndex = 25;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.Location = new System.Drawing.Point(367, 136);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(64, 64);
            this.btneliminar.TabIndex = 24;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneditar.BackgroundImage")));
            this.btneditar.Location = new System.Drawing.Point(297, 136);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(64, 64);
            this.btneditar.TabIndex = 23;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtcod_postal
            // 
            this.txtcod_postal.Location = new System.Drawing.Point(406, 71);
            this.txtcod_postal.MaxLength = 10;
            this.txtcod_postal.Name = "txtcod_postal";
            this.txtcod_postal.Size = new System.Drawing.Size(270, 20);
            this.txtcod_postal.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(406, 43);
            this.txtemail.MaxLength = 100;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(270, 20);
            this.txtemail.TabIndex = 10;
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.Location = new System.Drawing.Point(227, 136);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(64, 64);
            this.btnagregar.TabIndex = 22;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(406, 16);
            this.txttelefono.MaxLength = 6;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(270, 20);
            this.txttelefono.TabIndex = 9;
            // 
            // DGVproveedor
            // 
            this.DGVproveedor.AllowUserToAddRows = false;
            this.DGVproveedor.AllowUserToDeleteRows = false;
            this.DGVproveedor.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.DGVproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproveedor.Location = new System.Drawing.Point(41, 319);
            this.DGVproveedor.Name = "DGVproveedor";
            this.DGVproveedor.ReadOnly = true;
            this.DGVproveedor.Size = new System.Drawing.Size(643, 136);
            this.DGVproveedor.TabIndex = 28;
            this.DGVproveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproveedor_CellClick);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(70, 59);
            this.txtdireccion.MaxLength = 100;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(234, 20);
            this.txtdireccion.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(70, 28);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(234, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(331, 71);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 13);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Codigo Postal";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(331, 46);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Email";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(331, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Telefono";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 59);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Direccion";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Nombre";
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.Location = new System.Drawing.Point(157, 136);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(64, 64);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtcod_postal);
            this.GroupBox1.Controls.Add(this.txtemail);
            this.GroupBox1.Controls.Add(this.txttelefono);
            this.GroupBox1.Controls.Add(this.txtdireccion);
            this.GroupBox1.Controls.Add(this.txtnombre);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(16, 20);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(695, 100);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Proveedor";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(61, 126);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 31;
            this.txtId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id";
            this.label1.Visible = false;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(727, 517);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.DGVproveedor);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproveedor)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtbusprov;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btninicio;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnbuscar;
        internal System.Windows.Forms.Button btneliminar;
        internal System.Windows.Forms.Button btneditar;
        internal System.Windows.Forms.TextBox txtcod_postal;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Button btnagregar;
        internal System.Windows.Forms.TextBox txttelefono;
        internal System.Windows.Forms.DataGridView DGVproveedor;
        internal System.Windows.Forms.TextBox txtdireccion;
        internal System.Windows.Forms.TextBox txtnombre;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnguardar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}