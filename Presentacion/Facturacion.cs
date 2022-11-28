using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Entidades;
using Negocio;
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

        private L_Factura logicaFactura = new L_Factura();

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
            grilla.DataSource = tabla;

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

            Factura factura = new Factura();
            factura.Id_cliente = Convert.ToInt32(txtIdC.Text);
            factura.Fecha = txtFecha.Text;
            factura.Id_Producto = Convert.ToInt32(txtIdP.Text);  
            logicaFactura.Insertar(factura);
        }

        private void txtIdC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            
            logicaFactura.Actualizar(factura);  

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Id = int.Parse(txtIdF.Text);

            logicaFactura.Eliminar(int.Parse(txtIdF.Text));

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            logicaFactura.CargarDatos(grilla);
        }

        private void btnGuardaarFac_Click(object sender, EventArgs e)
        {

        }
    }
}
