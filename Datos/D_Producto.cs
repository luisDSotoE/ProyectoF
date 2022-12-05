using System.Data.OracleClient;
using System.Windows.Forms;
using System;
using Entidades;
using System.Data;

namespace Datos
{
    public class D_Producto
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=proyecto;USER ID = proyecto ");
        /// <summary>
        /// Inserta una cadena y inicializa con una nueva Id generada automaticamente
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool Insertar(Producto producto)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("insertarp", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", OracleType.VarChar).Value = producto.Nombre;
                comando.Parameters.Add("precio", OracleType.Number).Value = producto.Precio;
                comando.Parameters.Add("stock", OracleType.Number).Value = producto.Stock;
                comando.ExecuteNonQuery();
                comando.CommandType = CommandType.StoredProcedure;
                MessageBox.Show("producto insertado");
                ora.Close();
                return true;
            }
            catch (Exception ex)
            {
                ora.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Utilizando la Id(Id_Producto) identifica y modifica una cadena
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Retorna valores modificados</returns>
        public bool Actualizar(Producto producto)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizarp", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(producto.Id);
                comando.Parameters.Add("nom", OracleType.VarChar).Value = producto.Nombre;
                comando.Parameters.Add("precio", OracleType.Number).Value = Convert.ToInt32(producto.Precio);
                comando.Parameters.Add("stock", OracleType.Number).Value = Convert.ToInt32(producto.Stock);
                comando.ExecuteNonQuery();
                MessageBox.Show("PRODUCTO actualizada");
                ora.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Mediante una Id(Id_Producto) elimina una cadena de la base de datos
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>elimina la cadena</returns>
        public bool Eliminar(int idProducto)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("eliminarp", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(idProducto);
            comando.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            ora.Close();
            return true;
        }
        /// <summary>
        /// Carga los Datos que se encuentra en la base de Datos
        /// </summary>
        /// <param name="grilla"></param>
        /// <returns>Retorna todos los datos de la tabla</returns>
        public bool CargarDatos(DataGridView grilla)
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarPRODUCTO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                grilla.DataSource = tabla;
                ora.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}

