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
            this.btnexportar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DGVverprod.Size = new System.Drawing.Size(351, 292);
            this.DGVverprod.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleccione";
            this.Column1.Name = "Column1";
            // 
            // btnasignar
            // 
            this.btnasignar.Location = new System.Drawing.Point(369, 115);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(64, 41);
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
            this.Id,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Empresa});
            this.DGVverprod2.Location = new System.Drawing.Point(439, 12);
            this.DGVverprod2.Name = "DGVverprod2";
            this.DGVverprod2.ReadOnly = true;
            this.DGVverprod2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVverprod2.Size = new System.Drawing.Size(339, 292);
            this.DGVverprod2.TabIndex = 4;
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(650, 310);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(128, 40);
            this.btnexportar.TabIndex = 5;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // btninicio
            // 
            this.btninicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninicio.BackgroundImage")));
            this.btninicio.Location = new System.Drawing.Point(369, 12);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(64, 64);
            this.btninicio.TabIndex = 28;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // VerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(790, 360);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.DGVverprod2);
            this.Controls.Add(this.btnasignar);
            this.Controls.Add(this.DGVverprod);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        internal System.Windows.Forms.Button btninicio;
    }
}