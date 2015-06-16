namespace ProyectoInventario
{
    partial class VerProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProducto));
            this.DGVverprod = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnasignar = new System.Windows.Forms.Button();
            this.DGVverprod2 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexportar = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVverprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVverprod2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVverprod
            // 
            this.DGVverprod.AllowUserToAddRows = false;
            this.DGVverprod.AllowUserToDeleteRows = false;
            this.DGVverprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVverprod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DGVverprod.Location = new System.Drawing.Point(12, 12);
            this.DGVverprod.Name = "DGVverprod";
            this.DGVverprod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVverprod.Size = new System.Drawing.Size(644, 132);
            this.DGVverprod.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleccione";
            this.Column1.Name = "Column1";
            // 
            // btnasignar
            // 
            this.btnasignar.Location = new System.Drawing.Point(151, 150);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(55, 52);
            this.btnasignar.TabIndex = 2;
            this.btnasignar.Text = ">";
            this.btnasignar.UseVisualStyleBackColor = true;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // DGVverprod2
            // 
            this.DGVverprod2.AllowUserToAddRows = false;
            this.DGVverprod2.AllowUserToDeleteRows = false;
            this.DGVverprod2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVverprod2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Empresa});
            this.DGVverprod2.Location = new System.Drawing.Point(212, 150);
            this.DGVverprod2.Name = "DGVverprod2";
            this.DGVverprod2.ReadOnly = true;
            this.DGVverprod2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVverprod2.Size = new System.Drawing.Size(444, 134);
            this.DGVverprod2.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // btnexportar
            // 
            this.btnexportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexportar.BackgroundImage")));
            this.btnexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexportar.Location = new System.Drawing.Point(151, 232);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(55, 52);
            this.btnexportar.TabIndex = 5;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btninicio
            // 
            this.btninicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninicio.BackgroundImage")));
            this.btninicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btninicio.Location = new System.Drawing.Point(12, 232);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(55, 52);
            this.btninicio.TabIndex = 28;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // VerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(668, 296);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.DGVverprod2);
            this.Controls.Add(this.btnasignar);
            this.Controls.Add(this.DGVverprod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerProducto";
            this.Text = "VerProducto";
            this.Load += new System.EventHandler(this.VerProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVverprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVverprod2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVverprod;
        private System.Windows.Forms.Button btnasignar;
        private System.Windows.Forms.DataGridView DGVverprod2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnexportar;
        internal System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
    }
}