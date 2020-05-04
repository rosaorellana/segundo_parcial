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
    public partial class peliculas : Form
    {

        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public peliculas()
        {
            InitializeComponent();
        }

        private void peliculas_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["peliculas"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idPelicula"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblidPelicula.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtdescripcion.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtsinopsis.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtgenero.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtduracion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Pelicula",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Agregar")
            {
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "agregar";

                limpiar_cajas();
                controles(false);
            }
            else
            {
                String[] valores = {
                    lblidPelicula.Text,
                    txtdescripcion.Text,
                    txtsinopsis.Text,
                    txtgenero.Text,
                    txtduracion.Text,

                };
                objConexion.peliculas(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnagregar.Text = "Agregar";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "Modificar")
            {
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

            }
            else
            {
                controles(true);
                mostrarDatos();

                btnagregar.Text = "Agregar";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtdescripcion.Text, "Registro de Pelicula",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidPelicula.Text };
                objConexion.clientes(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            busqueda_peliculas frmBusquedaPeliculas = new busqueda_peliculas();
            frmBusquedaPeliculas.ShowDialog();

            if (frmBusquedaPeliculas._idPelicula > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaPeliculas._idPelicula));
                mostrarDatos();
            }
        }

        private void lblidPelicula_Click(object sender, EventArgs e)
        {

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {

            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Pelicula",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Pelicula",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtdescripcion.Text = "";
            txtsinopsis.Text = "";
            txtgenero.Text = "";
            txtduracion.Text = "";

        }
        void controles(Boolean valor)
        {

            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;

        }
    }

    }



