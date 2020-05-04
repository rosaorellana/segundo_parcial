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
    public partial class alquiler : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "agregar";
        DataTable tbl = new DataTable();
        public alquiler()
        {
            InitializeComponent();
        }

        private void alquiler_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_sistema_peliculasDataSet7.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.db_sistema_peliculasDataSet7.clientes);
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["alquiler"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idAlquiler"] };
        }

        void mostrarDatos()
        { 
            try
            {


            lblidAlquiler.Text = tbl.Rows[posicion].ItemArray[0].ToString();
            txtfechaprestamo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
            txtfechadevolucion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
            txtvalor.Text = tbl.Rows[posicion].ItemArray[3].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Alquiler",
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
                    lblidAlquiler.Text,
                    txtfechaprestamo.Text,
                    txtfechadevolucion.Text,
                    txtvalor.Text,
                    

                };
                objConexion.alquiler(valores, accion);
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
            if (MessageBox.Show("Esta seguro de eliminar a " + txtfechaprestamo.Text, "Registro de Alquiler",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidAlquiler.Text };
                objConexion.clientes(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            busqueda_alquiler frmBusquedaAlquiler = new busqueda_alquiler();
            frmBusquedaAlquiler.ShowDialog();

            if (frmBusquedaAlquiler._idAlquiler > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaAlquiler._idAlquiler));
                mostrarDatos();
            }
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
                MessageBox.Show("Primer Registro...", "Registros de Alquiler",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Alquiler",
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
            txtfechaprestamo.Text = "";
            txtfechadevolucion.Text = "";
            txtvalor.Text = "";
           

        }
        void controles(Boolean valor)
        {

            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
        }

       

       

        }
    }


                   