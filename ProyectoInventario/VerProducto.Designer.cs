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
            this.DGVverprod = new System.Windows.Forms.DataGridView();
            this.btnasignar = new System.Windows.Forms.Button();
            this.btndesignar = new System.Windows.Forms.Button();
            this.DGVverprod2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnexportar = new System.Windows.Forms.Button();
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
            this.DGVverprod.ReadOnly = true;
            this.DGVverprod.Size = new System.Drawing.Size(354, 292);
            this.DGVverprod.TabIndex = 0;
            // 
            // btnasignar
            // 
            this.btnasignar.Location = new System.Drawing.Point(372, 115);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(61, 34);
            this.btnasignar.TabIndex = 2;
            this.btnasignar.Text = ">";
            this.btnasignar.UseVisualStyleBackColor = true;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // btndesignar
            // 
            this.btndesignar.Location = new System.Drawing.Point(372, 155);
            this.btndesignar.Name = "btndesignar";
            this.btndesignar.Size = new System.Drawing.Size(61, 33);
            this.btndesignar.TabIndex = 3;
            this.btndesignar.Text = "<";
            this.btndesignar.UseVisualStyleBackColor = true;
            this.btndesignar.Click += new System.EventHandler(this.btndesignar_Click);
            // 
            // DGVverprod2
            // 
            this.DGVverprod2.AllowUserToAddRows = false;
            this.DGVverprod2.AllowUserToDeleteRows = false;
            this.DGVverprod2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVverprod2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.DGVverprod2.Location = new System.Drawing.Point(439, 12);
            this.DGVverprod2.Name = "DGVverprod2";
            this.DGVverprod2.ReadOnly = true;
            this.DGVverprod2.Size = new System.Drawing.Size(339, 292);
            this.DGVverprod2.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Seleccione";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleccione";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(650, 310);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(128, 40);
            this.btnexportar.TabIndex = 5;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = true;
            // 
            // VerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(790, 362);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.DGVverprod2);
            this.Controls.Add(this.btndesignar);
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
        private System.Windows.Forms.Button btndesignar;
        private System.Windows.Forms.DataGridView DGVverprod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnexportar;
    }
}