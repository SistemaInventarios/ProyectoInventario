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
    public partial class Producto : Form
    {
        Gestion ges = new Gestion();

        public int idproducto { get; set; }
        public string nombreproducto { get; set; }
        public int cantidadproducto { get; set; }
        public int precioproducto { get; set; }
        public string empresaproducto { get; set; }


        public Producto()
        {
            InitializeComponent();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            int cantidad = Convert.ToInt32(txtcantidad.Text);
            int precio = Convert.ToInt32(txtprecio.Text);
            string empresa = txtempresa.Text;
            
            ges.AgregarProducto(nombre, cantidad, precio, empresa);
            MessageBox.Show("Datos ingresados correctamente");
            txtnombre.Clear();
            txtcantidad.Clear();
            txtprecio.Clear();
            txtempresa.Clear();
            txtnombre.Focus();
        }

        private void txtbusprod_TextChanged(object sender, EventArgs e)
        {
            DGVproducto.DataSource = ges.BuscarProducto(txtbusprod.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            DGVproducto.DataSource = ges.mostrarProducto();
        }

        private void DGVproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.ReadOnly = true;
            txtcantidad.ReadOnly = true;
            txtprecio.ReadOnly = true;
            txtempresa.ReadOnly = true;

            try
            {
                txtId.Text = DGVproducto.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtnombre.Text = DGVproducto.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtcantidad.Text = DGVproducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtprecio.Text = DGVproducto.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtempresa.Text = DGVproducto.Rows[e.RowIndex].Cells[4].Value.ToString();

                string id = DGVproducto.Rows[e.RowIndex].Cells[0].Value.ToString();
                idproducto = Convert.ToInt32(id);
                nombreproducto = DGVproducto.Rows[e.RowIndex].Cells[1].Value.ToString();          
                string cantidad = DGVproducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                cantidadproducto = Convert.ToInt32(cantidad);
                string precio = DGVproducto.Rows[e.RowIndex].Cells[3].Value.ToString();
                precioproducto = Convert.ToInt32(precio);
                empresaproducto = DGVproducto.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            
            }
             
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {    
            int id = idproducto;
            ges.EliminarProducto(id);
            MessageBox.Show("Se Elimino Correctamente");
            DGVproducto.DataSource = ges.mostrarProducto();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtprecio.Clear();
            txtempresa.Clear();
            txtnombre.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtnombre.ReadOnly = false;
            txtcantidad.ReadOnly = false;
            txtprecio.ReadOnly = false;
            txtempresa.ReadOnly = false;
            btnguardar.Visible = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtnombre.Text;
            int cantidad = Convert.ToInt32(txtcantidad.Text);
            int precio = Convert.ToInt32(txtprecio.Text);
            string empresa = txtempresa.Text;

            ges.ActualizarProducto(id, nombre, cantidad, precio, empresa);
            MessageBox.Show("Se Edito Correctamente");
            btnguardar.Visible = false;
            DGVproducto.DataSource = ges.mostrarProducto();
            txtId.Clear();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtprecio.Clear();
            txtempresa.Clear();
            txtnombre.Focus();
        }

        private void DGVproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
