using Entidades;
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace Datos
{
    public class D_Cliente
    {
         /// <summary>
         /// Obtiene los datos de la base de datos e implementa en la grilla
         /// </summary>
         /// <param name="grilla"></param>
         /// <returns>Retorna una cadena de Datos de Cliente</returns>
        public bool CargarDatos(DataGridView grilla)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarCLIENTE", ora);
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
            }
        }
        
        /// <summary>
        /// Inserta los nuevos datos desde la aplicacion en la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>retorna una cadena de Datos de cliente e Inicializa con una nueva Id(Id_Cliente)</returns>
        public bool Insertar(Cliente cliente)
        {
            try
            {
                OracleConnection oracleConexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                oracleConexion.Open();
                OracleCommand comando = new OracleCommand("INSERTAR", oracleConexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", OracleType.VarChar).Value = cliente.Nombres;
                comando.Parameters.Add("Ape", OracleType.VarChar).Value = cliente.Apellidos;
                comando.Parameters.Add("Dir", OracleType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("Tel", OracleType.Number).Value = cliente.Telefono;
                comando.Parameters.Add("email", OracleType.VarChar).Value = cliente.Correo;
                comando.ExecuteNonQuery();
                comando.CommandType = CommandType.StoredProcedure; 
                oracleConexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        /// <summary>
        ///  elimina a un cliente por Id(Id_Cliente)
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Elimina al cliente seleccionado</returns>
        public bool Eliminar(int idCliente)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("eliminar", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idc", OracleType.Number).Value = idCliente;
                comando.ExecuteNonQuery();
                ora.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        
        /// <summary>
        /// hace la conexion y modifica los datos de una persona
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Retorna una cadena modificada de la base de datos</returns>
        public bool Actualizar(Cliente cliente)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizar", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idc", OracleType.Number).Value = cliente.Id;
                comando.Parameters.Add("Nom", OracleType.VarChar).Value = cliente.Nombres;
                comando.Parameters.Add("Ape", OracleType.VarChar).Value = cliente.Apellidos;
                comando.Parameters.Add("Dir", OracleType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("Tel", OracleType.Number).Value = cliente.Telefono;
                comando.Parameters.Add("email", OracleType.VarChar).Value = cliente.Correo;
                comando.ExecuteNonQuery();
                ora.Close();
                return true;
            }
            catch (Exception)
            {
                ora.Close();
                return false;
                throw;
            }
        }
    }
}
