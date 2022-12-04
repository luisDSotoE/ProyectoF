using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Datos
{
    public class D_Rol
    {

        public bool CargarDatos(DataGridView grilla)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=facturacion;USER ID = facturacion ");
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarROL", ora);
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
    }
}