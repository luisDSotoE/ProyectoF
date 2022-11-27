using System.Data.OracleClient;
using System.Windows.Forms;
using System;
using Entidades;
using System.Data;

namespace Datos
{
    public class D_Producto
    {
        public bool Insertar(Producto producto)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTAR3", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", OracleType.VarChar).Value = producto.Nombre;
                comando.Parameters.Add("precio", OracleType.VarChar).Value = producto.Precio;
                comando.Parameters.Add("stock", OracleType.VarChar).Value = producto.Stock;
                comando.Parameters.Add("idf", OracleType.Number).Value = producto.Id_factura;
                comando.ExecuteNonQuery();
                MessageBox.Show("CLIENTE insertada");
                ora.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Actualizar(Producto producto)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizar3", ora);
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

        public bool Eliminar(int idProducto)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
            ora.Open();
            OracleCommand comando = new OracleCommand("eliminar3", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(idProducto);
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

