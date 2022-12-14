using Presentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        void abrirForm(Form form) {
            while (PanelGeneral.Controls.Count > 0) {
                PanelGeneral.Controls.RemoveAt(0);
            }
            Form Hijo = form;
            form.TopLevel = false;
            Hijo.FormBorderStyle = FormBorderStyle.None;
            Hijo.Dock = DockStyle.Fill;
            PanelGeneral.Text = Hijo.Text;
            PanelGeneral.Controls.Add(Hijo);
            Hijo.Show();
        }

        private void btn_Mercancia_Click(object sender, EventArgs e)
        {
            //IngMercancia Frm = new IngMercancia();
            //abrirForm(Frm);
            //Frm.TopLevel = false;
            //PanelGeneral.Controls.Add(Frm);
            //Frm.Show();
        }

        private void btn_costos_Click(object sender, EventArgs e)
        {
            //Costos Frm = new Costos();
            //abrirForm(Frm);
            //Frm.TopLevel = false;
            //PanelGeneral.Controls.Add(Frm);
            //Frm.Show();
        }

        private void btn_audMovimietos_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            Facturacion Frm = new Facturacion();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            //Pedidos Frm = new Pedidos();
            //abrirForm(Frm);
            //Frm.TopLevel = false;
            //PanelGeneral.Controls.Add(Frm);
            //Frm.Show();
        }

        private void btn_Despachar_Click(object sender, EventArgs e)
        {
            //DesMercancia Frm = new DesMercancia();
            //abrirForm(Frm);
            //Frm.TopLevel = false;
            //PanelGeneral.Controls.Add(Frm);
            //Frm.Show();
        }

        private void btn_audmovimientos_Click(object sender, EventArgs e)
        {

        }

        private void btn_FA_Click(object sender, EventArgs e)
        {
            FrmProductos Frm = new FrmProductos();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_SM_Click(object sender, EventArgs e)
        {
            //SemillasyMateriales Frm = new SemillasyMateriales();
            //abrirForm(Frm);
            //Frm.TopLevel = false;
            //PanelGeneral.Controls.Add(Frm);
            //Frm.Show();
        }

        private void btn_Maquinaria_Click(object sender, EventArgs e)
        {

        }

        private void Programa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { e.Cancel = true; }
            else { e.Cancel = false; Environment.Exit(1); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCliente Frm = new FrmCliente();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FrmUsuario Frm = new FrmUsuario();
            //abrirForm(Frm);
            //Frm.TopLevel = false;
            //PanelGeneral.Controls.Add(Frm);
            //Frm.Show();
        }
    }
}
