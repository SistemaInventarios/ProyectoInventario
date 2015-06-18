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
    public partial class Proveedor : Form
    {
        Gestion ges = new Gestion();

        public int idproveedor { get; set; }
        public string nombreproveedor { get; set; }
        public string direccionproveedor { get; set; }
        public int telefonoproveedor { get; set; }
        public string emailproveedor { get; set; }
        public int cod_postalproveedor { get; set; }

        public Proveedor()
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
            string direccion = txtdireccion.Text;
            int telefono = Convert.ToInt32(txttelefono.Text);
            string email = txtemail.Text;
            int cod_postal = Convert.ToInt32(txtcod_postal.Text);
            
            object valor = nombreproveedor;
                //Ahora compárelo con el texto en la casilla de texto:
                if (String.Compare(txtnombre.Text, valor.ToString()) == 0)
                {
                    MessageBox.Show("Ya Exise el Producto!");
                    txtnombre.ReadOnly = false;
                    txtdireccion.ReadOnly = false;
                    txttelefono.ReadOnly = false;
                    txtemail.ReadOnly = false;
                    txtcod_postal.ReadOnly = false;
                    txtId.Clear();
                    txtnombre.Clear();
                    txtdireccion.Clear();
                    txttelefono.Clear();
                    txtemail.Clear();
                    txtcod_postal.Clear();
                    txtnombre.Focus();
                }
                else
                {
                    ges.AgregarProveedor(nombre, direccion, telefono, email, cod_postal);
                    MessageBox.Show("Datos ingresados correctamente");
                    txtId.Clear();
                    txtnombre.Clear();
                    txtdireccion.Clear();
                    txttelefono.Clear();
                    txtemail.Clear();
                    txtcod_postal.Clear();
                    txtnombre.Focus();
                    txtnombre.ReadOnly = false;
                    txtdireccion.ReadOnly = false;
                    txttelefono.ReadOnly = false;
                    txtemail.ReadOnly = false;
                    txtcod_postal.ReadOnly = false;
                }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtnombre.ReadOnly = false;
            txtdireccion.ReadOnly = false;
            txttelefono.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtcod_postal.ReadOnly = false;
            btnguardar.Visible = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = idproveedor;
            ges.EliminarProveedor(id);
            MessageBox.Show("Se Elimino Correctamente");
            DGVproveedor.DataSource = ges.mostrarProveedor();
            txtId.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtcod_postal.Clear();
            txtnombre.Focus();
            txtnombre.ReadOnly = false;
            txtdireccion.ReadOnly = false;
            txttelefono.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtcod_postal.ReadOnly = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            DGVproveedor.DataSource = ges.mostrarProveedor();
        }

        private void txtbusprov_TextChanged(object sender, EventArgs e)
        {
            DGVproveedor.DataSource = ges.BuscarProveedor(txtbusprov.Text);
        }

        private void DGVproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.ReadOnly = true;
            txtdireccion.ReadOnly = true;
            txttelefono.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtcod_postal.ReadOnly = true;

            try
            {
                txtId.Text = DGVproveedor.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtnombre.Text = DGVproveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdireccion.Text = DGVproveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                txttelefono.Text = DGVproveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = DGVproveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtcod_postal.Text = DGVproveedor.Rows[e.RowIndex].Cells[5].Value.ToString();

                string id = DGVproveedor.Rows[e.RowIndex].Cells[0].Value.ToString();
                idproveedor = Convert.ToInt32(id);
                nombreproveedor = DGVproveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
                direccionproveedor = DGVproveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                string telefono = DGVproveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                telefonoproveedor = Convert.ToInt32(telefono);
                emailproveedor = DGVproveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                string cod_postal = DGVproveedor.Rows[e.RowIndex].Cells[5].Value.ToString();
                cod_postalproveedor = Convert.ToInt32(cod_postal);
                
            }
            catch (Exception)
            {

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtnombre.Text;
            string direccion = txtdireccion.Text;
            int telefono = Convert.ToInt32(txttelefono.Text);
            string email = txtemail.Text;
            int cod_postal = Convert.ToInt32(txtcod_postal.Text);
            
            ges.ActualizarProveedor(id, nombre, direccion, telefono, email, cod_postal);
            MessageBox.Show("Se Edito Correctamente");
            btnguardar.Visible = false;
            DGVproveedor.DataSource = ges.mostrarProveedor();
            txtId.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtcod_postal.Clear();
            txtnombre.Focus();
            txtnombre.ReadOnly = false;
            txtdireccion.ReadOnly = false;
            txttelefono.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtcod_postal.ReadOnly = false;
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
