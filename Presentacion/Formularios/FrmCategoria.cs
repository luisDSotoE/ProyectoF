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

namespace Presentacion.Formularios
{
    public partial class FrmCategoria : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=parcial;USER ID = parcial ");
        public FrmCategoria()
        {
            InitializeComponent();
        }

        L_Categoria LogicaCategoria = new L_Categoria();

        private void AgregarCategoria()
        {
            Categoria categoria = new Categoria();
            categoria.DescripcionCategoria = txtNombre.Text;

            LogicaCategoria.Insertar(categoria);

            MessageBox.Show("Categoria registrada exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Text = "";
            LogicaCategoria.CargarDatos(Grilla);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCategoria();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            LogicaCategoria.CargarDatos(Grilla);
        }

        private void btnElimna_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Ingrese el id de la categoria que desea elimiar.");
                    txtId.Select();
                }
                else
                {
                    LogicaCategoria.Eliminar(Convert.ToInt32(txtId.Text));
                    if (!LogicaCategoria.Eliminar(Convert.ToInt32(txtId.Text)))
                    {
                        MessageBox.Show("No se eliminó el categoria");
                    }
                    else { MessageBox.Show("Si eliminó el categoria correctamente."); }
                    LogicaCategoria.CargarDatos(Grilla);
                    txtId.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizarct", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idct", OracleType.Number).Value = Convert.ToInt32(txtId.Text);
                comando.Parameters.Add("dcat", OracleType.VarChar).Value = txtNombre.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Categoria actualizada.");
                ora.Close();

            }
            catch (Exception ex)
            {
                ora.Close();

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ora.Close();

            LogicaCategoria.CargarDatos(Grilla);
            txtId.Text = "";
            txtNombre.Text = "";
        }
    }
}
