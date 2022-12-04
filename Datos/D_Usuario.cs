using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;
using System;
using Entidades;

namespace Datos
{
    public class D_Usuario
    {
        public bool CargarDatos(DataGridView grilla)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=facturacion;USER ID = facturacion ");
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarUSUARIO", ora);
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
        public bool Insertar(Usuario usuario)
        {
            try
            {
                OracleConnection oracleConexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD=facturacion;USER ID = facturacion ");
                oracleConexion.Open();
                OracleCommand comando = new OracleCommand("INSERTARU", oracleConexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("doc", OracleType.VarChar).Value = usuario.Documento;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = usuario.Nombre;
                comando.Parameters.Add("ape", OracleType.VarChar).Value = usuario.Apellido;
                comando.Parameters.Add("correo", OracleType.VarChar).Value = usuario.Correo;
                comando.Parameters.Add("clave", OracleType.VarChar).Value = usuario.Contraseña;
                comando.Parameters.Add("idr", OracleType.Number).Value = usuario.ObJRol;
                comando.Parameters.Add("fechar", OracleType.DateTime).Value = usuario.FechaRegistro;

                comando.ExecuteNonQuery();
                comando.CommandType = CommandType.StoredProcedure;
                MessageBox.Show("USUARIO insertado");
                oracleConexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Eliminar(int idUsuario)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=facturacion;USER ID = facturacion ");
                ora.Open();
                OracleCommand comando = new OracleCommand("eliminaru", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idu", OracleType.Number).Value = idUsuario;
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
        public bool Actualizar(Usuario usuario)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=facturacion;USER ID = facturacion ");
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizaru", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idu", OracleType.Number).Value = usuario.IdUsuario;
                comando.Parameters.Add("doc", OracleType.VarChar).Value = usuario.Documento;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = usuario.Nombre;
                comando.Parameters.Add("ape", OracleType.VarChar).Value = usuario.Apellido;
                comando.Parameters.Add("correo", OracleType.VarChar).Value = usuario.Correo;
                comando.Parameters.Add("clave", OracleType.VarChar).Value = usuario.Contraseña;
                comando.Parameters.Add("idr", OracleType.Number).Value = usuario.ObJRol;
                comando.Parameters.Add("fechar", OracleType.DateTime).Value = usuario.FechaRegistro;
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
