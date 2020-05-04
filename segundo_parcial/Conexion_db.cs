using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace segundo_parcial
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema_peliculas.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;

        }
        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from peliculas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "peliculas");

            comandosSQL.CommandText = "select * from alquiler";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "alquiler");

            return ds;

        }
        public void clientes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "agregar")
            {
                sql = "INSERT INTO clientes (nombre,direccion,telefono,dui) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET " +
                    "nombre         = '" + datos[1] + "'," +
                    "direccion      = '" + datos[2] + "'," +
                    "telefono       = '" + datos[3] + "'," +
                    "dui            = '" + datos[4] + "'," +
                  
                   "WHERE idCliente = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idCliente='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void peliculas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "agregar")
            {
                sql = "INSERT INTO peliculas (descripcion,sinopsis,genero,duracion) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +

                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE peliculas SET " +
                    "descripcion         = '" + datos[1] + "'," +
                    "sinopsis      = '" + datos[2] + "'," +
                    "genero        = '" + datos[3] + "'," +
                    "duracion            = '" + datos[4] + "'," +

                    "WHERE idPelicula = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE peliculas FROM peliculas WHERE idPelicula ='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void alquiler(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "agregar")
            {
                sql = "INSERT INTO alquiler (fechaprestamo,fechadevolucion,valor) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                   

                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alquiler SET " +
                    "fechaprestamo         = '" + datos[1] + "'," +
                    "fechadevolucion      = '" + datos[2] + "'," +
                    "valor        = '" + datos[3] + "'," +
                    

                    "WHERE idAlquiler = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE alquiler FROM alquiler WHERE idAlquiler ='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
        }

    }
    }

