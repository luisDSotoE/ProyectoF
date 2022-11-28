using Entidades;
using System.Data.OracleClient;
using System.Windows.Forms;
using System;
using System.Data;

namespace Datos
{
    public class D_Factura
    {
        /// <summary>
        /// Inserta los nuevos datos desde la aplicacion en la base de datos(Factura)
        /// </summary>
        /// <param name="factura"></param>
        /// <returns>Retorna una cadena nueva creada por el usuario</returns>
        public bool Insertar(Factura factura)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTAR2", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idc", OracleType.Number).Value = factura.Id_cliente;
                comando.Parameters.Add("fecha", OracleType.VarChar).Value = factura.Fecha;
                comando.Parameters.Add("Idp", OracleType.Number).Value = factura.Id_Producto;
                comando.ExecuteNonQuery();
                MessageBox.Show("FACTURA insertada");
                ora.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        /// <summary>
        /// Utiliza la Id(Id_cliente) para identificar y modificar una cadena
        /// </summary>
        /// <param name="factura"></param>
        /// <returns>Retorna valores modificados</returns>
        public bool Actualizar(Factura factura)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizar2", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idf", OracleType.Number).Value = Convert.ToInt32(factura.Id);
                comando.Parameters.Add("idc", OracleType.Number).Value = Convert.ToInt32(factura.Id_cliente);
                comando.Parameters.Add("fecha", OracleType.VarChar).Value = factura.Fecha;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(factura.Id_Producto);
                comando.ExecuteNonQuery();
                MessageBox.Show("FACTURA actualizada");
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
        /// Por medio de una Id(Id_Factura) elimina una cadena de la tabla Cliente
        /// </summary>
        /// <param name="IdFactura"></param>
        /// <returns>Elimina la factura seleccionada</returns>
        public bool Eliminar(int IdFactura)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
            ora.Open();
            OracleCommand comando = new OracleCommand("eliminar2", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idf", OracleType.Number).Value = Convert.ToInt32(IdFactura);
            comando.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            ora.Close();
            return true;
        }
        /// <summary>
        /// Carga los datos en grilla
        /// </summary>
        /// <param name="grilla"></param>
        /// <returns>Retorna una cadena de Datos Factura</returns>
        public bool CargarDatos(DataGridView grilla)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarFACTURA", ora);
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
