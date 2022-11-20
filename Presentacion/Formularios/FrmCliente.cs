using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        public static ServicioClienteImpl clienteImpl = new ServicioClienteImpl();
        int posicion = 0;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Grilla.DataSource = clienteImpl.Listar();
        }
    }
}
