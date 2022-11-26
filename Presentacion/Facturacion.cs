using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Facturacion : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
        public Facturacion()
        {
            InitializeComponent();
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        

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
            dataGridView2.DataSource = tabla;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTAR2", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idc", OracleType.Number).Value = txtIdC.Text;
                comando.Parameters.Add("fecha", OracleType.VarChar).Value = txtFecha.Text;
                comando.Parameters.Add("Idp", OracleType.Number).Value = txtIdP.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("FACTURA insertada");
                ora.Close();


            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ora.Close();

        }

        private void txtIdC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizar2", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idf", OracleType.Number).Value = Convert.ToInt32(txtIdF.Text);
                comando.Parameters.Add("idc", OracleType.Number).Value = Convert.ToInt32(txtIdC.Text);
                comando.Parameters.Add("fecha", OracleType.VarChar).Value = txtFecha.Text;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIdP.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("FACTURA actualizada");
                ora.Close();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ora.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
            ora.Open();
            OracleCommand comando = new OracleCommand("eliminar2", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idf", OracleType.Number).Value = Convert.ToInt32(txtIdF.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            ora.Close();
        }
    }
}
