using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_parcial
{
    public partial class busqueda_alquiler : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idAlquiler;
        public busqueda_alquiler()
        {
            InitializeComponent();
        }

        private void frmBusquedaAlquiler_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sistema_peliculasDataSet6.alquiler' Puede moverla o quitarla según sea necesario.
            this.alquilerTableAdapter.Fill(this.db_sistema_peliculasDataSet6.alquiler);
            grdBusquedaAlquiler.DataSource =
             objConexion.obtener_datos().Tables["alquiler"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaAlquiler.DataSource;
            bs.Filter = "fechaprestamo like '%" + valor + "%'";
            grdBusquedaAlquiler.DataSource = bs;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaAlquiler.RowCount > 0)
            {
                _idAlquiler = int.Parse(grdBusquedaAlquiler.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda Alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void grdBusquedaAlquiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

