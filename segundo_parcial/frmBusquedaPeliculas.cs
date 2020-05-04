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
    public partial class busqueda_peliculas : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idPelicula;
        public busqueda_peliculas()
        {
            InitializeComponent();
        }

        private void frmBusquedaPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sistema_peliculasDataSet1.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.db_sistema_peliculasDataSet1.peliculas);
            grdBusquedaPeliculas.DataSource =
              objConexion.obtener_datos().Tables["peliculas"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaPeliculas.DataSource;
            bs.Filter = "descripcion like '%" + valor + "%'";
            grdBusquedaPeliculas.DataSource = bs;
        }
        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaPeliculas.RowCount > 0)
            {
                _idPelicula = int.Parse(grdBusquedaPeliculas.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda Peliculas",
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

       
        }
    }

    

