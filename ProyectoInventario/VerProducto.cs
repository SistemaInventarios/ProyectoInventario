using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
                DGVverprod2.Rows.Add(new object[] {
                                            //row.Cells[0].Value,
                                            //row.Cells[1].Value,
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

        private void btnexportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(DGVverprod2);
        }

        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
