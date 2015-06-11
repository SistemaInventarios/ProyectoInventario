using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor prove = new Proveedor();
            prove.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Sistema de Inventario", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void verProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProducto verprod = new VerProducto();
            verprod.Show();
            this.Hide();
        }
    }
}
