using System.Data.OracleClient;
using System.Windows.Forms;
using System;
using Entidades;
using System.Data;

namespace Datos
{
    public class D_Producto
    {
        /// <summary>
        /// Inserta una cadena y inicializa con una nueva Id generada automaticamente
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool Insertar(Producto producto)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=sistemaf;USER ID = sistemaf ");
                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTARP", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", OracleType.VarChar).Value = producto.Nombre;
                comando.Parameters.Add("precio", OracleType.VarChar).Value = producto.Precio;
                comando.Parameters.Add("stock", OracleType.VarChar).Value = producto.Stock;
                comando.Parameters.Add("idf", OracleType.Number).Value = producto.Id_factura;
                comando.ExecuteNonQuery();
                MessageBox.Show("producto insertado");
                ora.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=sistemaf;USER ID = sistemaf ");
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizarp", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(producto.Id);
                comando.Parameters.Add("nom", OracleType.VarChar).Value = producto.Nombre;
                comando.Parameters.Add("precio", OracleType.Number).Value = Convert.ToInt32(producto.Precio);
                comando.Parameters.Add("stock", OracleType.Number).Value = Convert.ToInt32(producto.Stock);
                comando.Parameters.Add("idf", OracleType.Number).Value = Convert.ToInt32(producto.Id_factura);
                comando.ExecuteNonQuery();
                MessageBox.Show("PRODUCTO actualizada");
                ora.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Mediante una Id(Id_Producto) elimina una cadena de la base de datos
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>elimina la cadena</returns>
        public bool Eliminar(int idProducto)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=sistemaf;USER ID = sistemaf ");
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
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=sistemaf;USER ID = sistemaf ");
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarPRODUCTO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                grilla.DataSource = tabla;
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

