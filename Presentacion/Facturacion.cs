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
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=facturacion;USER ID = facturacion ");
        public Facturacion()
        {
            InitializeComponent();
        }

        private L_Factura logicaFactura = new L_Factura();

        private void CargarDatos_Click(object sender, EventArgs e)


        {
            
            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarFACTURA", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Grilla.DataSource = tabla;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Id = Convert.ToInt32(txtIdF.Text);
            factura.Id_cliente = Convert.ToInt32(txtIdC.Text);
            factura.Fecha = txtFecha.Text;
            factura.Id_Producto = Convert.ToInt32(txtIdP.Text);


            logicaFactura.Actualizar(factura);
            MessageBox.Show("factura actualizada correctamente");
            logicaFactura.CargarDatos(Grilla);
            txtIdF.Text = "";
            txtIdC.Text = "";
            txtFecha.Text = "";
            txtIdP.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Id = int.Parse(txtIdF.Text);

            logicaFactura.Eliminar(int.Parse(txtIdF.Text));
            logicaFactura.CargarDatos(Grilla);
            txtIdF.Text = "";

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            logicaFactura.CargarDatos(Grilla);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Id_cliente = Convert.ToInt32(txtIdC.Text);
            factura.Fecha = txtFecha.Text;
            factura.Id_Producto = Convert.ToInt32(txtIdP.Text);
            logicaFactura.Insertar(factura);
            logicaFactura.CargarDatos(Grilla);
            txtIdF.Text = "";
            txtIdC.Text = "";
            txtFecha.Text = "";
            txtIdP.Text = "";
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtConsultar.Text != "")
            {
                //Tabla
                Grilla.CurrentCell = null;

                foreach (DataGridViewRow row in Grilla.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in Grilla.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value.ToString().ToUpperInvariant().IndexOf(txtConsultar.Text.ToUpperInvariant()) == 0))
                        {
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in Grilla.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        row.Visible = true;
                    }
                }
            }
        }
    }
}
