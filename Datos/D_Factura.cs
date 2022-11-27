using Entidades;
using System.Data.OracleClient;
using System.Windows.Forms;
using System;
using System.Data;

namespace Datos
{
    public class D_Factura
    {
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
