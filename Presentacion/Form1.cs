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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomiceDesing();
        }

        private void CustomiceDesing()
        {
            panelSudMenuInicio.Visible = false;
            panel_SudMenuFact.Visible = false;
            
        }
        private void HidSudMenu()
        {
            if (panelSudMenuInicio.Visible == true)
                //panelSudMenuInicio = false;
            if (panel_SudMenuFact.Visible == true)
                panel_SudMenuFact.Visible = false;
        }

        private void showSudMenu(Panel sudMenu)
        {
            if (sudMenu.Visible == false)
            {
                HidSudMenu();
                sudMenu.Visible = true;
            }
            else
                sudMenu.Visible = false;
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
            IngMercancia Frm = new IngMercancia();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_costos_Click(object sender, EventArgs e)
        {
            Costos Frm = new Costos();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_audMovimietos_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_INICIO_Click(object sender, EventArgs e)
        {
            showSudMenu(panelSudMenuInicio);
            HidSudMenu();
        }

        private void btn_Fact_Click(object sender, EventArgs e)
        {
            showSudMenu(panel_SudMenuFact);
            HidSudMenu();
        }

        private void panelSudMenuInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_SudMenuFact_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            Pedidos Frm = new Pedidos();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_Despachar_Click(object sender, EventArgs e)
        {
            DesMercancia Frm = new DesMercancia();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_audmovimientos_Click(object sender, EventArgs e)
        {

        }

        private void btn_FA_Click(object sender, EventArgs e)
        {
            FertilizanteYAgroquimicos Frm = new FertilizanteYAgroquimicos();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_SM_Click(object sender, EventArgs e)
        {
            SemillasyMateriales Frm = new SemillasyMateriales();
            abrirForm(Frm);
            Frm.TopLevel = false;
            PanelGeneral.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_Maquinaria_Click(object sender, EventArgs e)
        {

        }
    }
}
