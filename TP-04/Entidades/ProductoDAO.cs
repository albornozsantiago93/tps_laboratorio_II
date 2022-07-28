using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // SE IMPLEMTNA LA UNDAD 15
    // INTRODUCCION A BASE DE DATOS
    public class ProductoDAO
    {
        static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        public delegate void DAOHandler();
        public event DAOHandler OnFinalizoLeer;


        static ProductoDAO()
        {
            connectionString = @"Server=.\SQLEXPRESS;Database= master;Trusted_Connection=True;";
            //FALTA CREAR DATABASE, ESTA EN MASTER
        }

        /// <summary>
        /// CONSTRUCTOR PARA LA CONEXCION A BASE DE DATOS
        /// </summary>
        public ProductoDAO()
        {
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.CommandType = System.Data.CommandType.Text;
            this.command.Connection = this.connection;
        }

        /// <summary>
        /// OBTIENE LA LISTA DE PRODUCTOS DE EN LA BASE DE DATOS
        /// </summary>
        /// <returns></returns>
        public List<Producto> Leer()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                string query = "SELECT * FROM productos";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);

                    //float precio = dataReader.GetFloat(2);

                    int precio = dataReader.GetInt32(2);
                    DateTime fechaElaboracion = dataReader.GetDateTime(3);
                    DateTime fechaVencimiento = dataReader.GetDateTime(4);
                    int cantidad = dataReader.GetInt32(5);                    

                    Producto producto = new Producto(nombre, float.Parse(precio.ToString()), fechaElaboracion, fechaVencimiento, cantidad, id);

                    lista.Add(producto);
                }

                if (OnFinalizoLeer != null)
                {
                    OnFinalizoLeer.Invoke();
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new ErrorEnBaseDeDatosException("Error al traer los Productos de la base de datos", ex);
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// GUARDA PRODUCTO EN LA BASE DE DATOS
        /// </summary>
        /// <param name="producto"></param>
        public bool Guardar(Producto producto)
        {
            bool retorno = false;

            try
            {
                connection.Open();
                string query =
                    "INSERT INTO Productos (nombre, precio, fechaElaboracion, fechaVencimiento, cantidad) VALUES (@nombre, @precio, @fechaElaboracion, @fechaVencimiento, @cantidad)";

                this.command.CommandText = query;
                this.command.Parameters.Clear();
                this.command.Parameters.AddWithValue("@nombre", producto.Nombre);
                this.command.Parameters.AddWithValue("@precio", producto.Precio);
                this.command.Parameters.AddWithValue("@fechaElaboracion", producto.FechaDeElaboracion);
                this.command.Parameters.AddWithValue("@fechaVencimiento", producto.FechaDeVencimiento);
                this.command.Parameters.AddWithValue("@cantidad", producto.Cantidad);                
                this.command.ExecuteNonQuery();
                retorno = true;
            }
            catch(Exception ex)
            {
                throw new ErrorEnBaseDeDatosException("Error al traer los Productos de la base de datos", ex);
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }

    }
}


