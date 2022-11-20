using Entidades;
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

        private bool Validacion()
        {
            if (txtNombres.Text == "")
            {
                MessageBox.Show("El campo de nombres está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombres.Focus();
                return true;
            }
            else if (txtApellidos.Text == "")
            {
                MessageBox.Show("El campo de apellidos está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellidos.Focus();
                return true;
            }
            else if (txtDocumento.Text == "")
            {
                MessageBox.Show("El campo de documento está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumento.Focus();
                return true;
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("El campo de correo está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return true;
            }
            else
            {
                //No hay campos vacíos
                return false;
            }
        }

        private void FiltrarBusqueda()
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
                Grilla.DataSource = null;
                Grilla.DataSource = clienteImpl.Listar();
            }
        }

        private void CrearCliente()
        {
            Cliente cliente = new Cliente();

            cliente.Nombres = txtNombres.Text.ToUpperInvariant();
            cliente.Apellidos = txtApellidos.Text.ToUpperInvariant();
            cliente.Documento = txtDocumento.Text.ToUpperInvariant();
            cliente.Direccion = txtCorreo.Text.ToUpperInvariant();
            cliente.TipoCliente = boxTipo.Text.ToUpperInvariant();

            Random numeroRandom = new Random();
            cliente.Id = numeroRandom.Next(0, 1000000);

            clienteImpl.Agregar(cliente);
            Grilla.DataSource = null;
            Grilla.DataSource = clienteImpl.Listar();
        }

        private void LimpiarCampos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDocumento.Text = "";
            txtCorreo.Text = "";
        }

        private void AgregarCliente()
        {

            if (BtnAgregar.Text == "Agregar")
            {
                try
                {
                    if (Validacion() == true)
                    {

                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Desea agregar el cliente "
                        + txtNombres.Text.ToUpperInvariant() + " " + txtApellidos.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            bool clienteExistente = false;

                            foreach (var item in clienteImpl.Listar())
                            {
                                if (item.Documento.ToString() == txtDocumento.Text.ToUpperInvariant())
                                {
                                    clienteExistente = true;
                                    break;
                                }
                            }

                            if (clienteExistente)
                            {
                                MessageBox.Show("Ya existe un clienter con el documento " + txtDocumento.Text.ToUpperInvariant()
                                    + " registrado.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                CrearCliente();
                                LimpiarCampos();

                                MessageBox.Show("Cliente creado exitosamente.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //ModificarCategoria();
            }
        }

        private void EliminarCliente()
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el cliente "
                + Grilla[1, posicion].Value + " del registro?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    clienteImpl.Eliminar(clienteImpl.Listar()[posicion]);
                    MessageBox.Show("Cliente eliminado correctamente.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Grilla.DataSource = null;
                    Grilla.DataSource = clienteImpl.Listar();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteImpl.Listar().Count == 0)
            {
                MessageBox.Show("No hay clientes registrados.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (posicion < 0)
                {
                    MessageBox.Show("Seleccione un registro.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //LocalizarRegistro(clienteImpl.Listar()[posicion]);
                    EliminarCliente();
                }
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Grilla.DataSource = clienteImpl.Listar();
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarBusqueda();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite numeros.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
    }
}
