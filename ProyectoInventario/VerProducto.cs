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
    public partial class VerProducto : Form
    {
        Gestion ges = new Gestion();

        public VerProducto()
        {
            InitializeComponent();
        }

        private void VerProducto_Load(object sender, EventArgs e)
        {
            DGVverprod.DataSource = ges.mostrarProducto();
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            //
            // Se define una lista temporal de registro seleccionados
            //
            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();

            //
            // Se recorre ca registro de la grilla de origen
            //
            foreach (DataGridViewRow row in DGVverprod.Rows)
            {
                //
                // Se recupera el campo que representa el checkbox, y se valida la seleccion
                // agregandola a la lista temporal
                //
                DataGridViewCheckBoxCell cellSeleccion = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    rowSelected.Add(row);
                }
            }

            //
            // Se agrega el item seleccionado a la grilla de destino
            // eliminando la fila de la grilla original
            //
            foreach (DataGridViewRow row in rowSelected)
            {
                DGVverprod2.Rows.Add(new object[] {false,
                                            row.Cells[1].Value,
                                            row.Cells[2].Value,
                                            row.Cells[3].Value,
                                            row.Cells[4].Value,
                                            row.Cells[5].Value});

                DGVverprod.Rows.Remove(row);
            }
            
        }

        private void btndesignar_Click(object sender, EventArgs e)
        {

        }
    }
}
