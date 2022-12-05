using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Datos
{
    public class D_Categoria
    {
        readonly OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=parcial;USER ID = parcial ");
       

        public bool CargarDatos(DataGridView grilla)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarCATEGORIA", ora)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter
                {
                    SelectCommand = comando
                };
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

        public bool Insertar(Categoria categoria)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("insertact", ora)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                comando.Parameters.Add("dcat", OracleType.VarChar).Value = categoria.DescripcionCategoria;
                comando.ExecuteNonQuery();
                comando.CommandType = CommandType.StoredProcedure;
                ora.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool Eliminar(int idCategoria)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("eliminarct", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idct", OracleType.Number).Value = idCategoria;
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
        
        public bool Actualizar(Categoria categoria)
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizarct", ora)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                comando.Parameters.Add("idct", OracleType.Number).Value = categoria.IdCategoria;
                comando.Parameters.Add("dcat", OracleType.VarChar).Value = categoria.DescripcionCategoria;
                
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
