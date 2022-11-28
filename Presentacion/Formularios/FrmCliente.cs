using Entidades;
using Negocio;
using System;
using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Presentacion.Formularios
{
    public partial class FrmCliente : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
        public FrmCliente()
        {
            InitializeComponent();
        }

        int posicion = 0;

        L_Cliente logicaCliente = new L_Cliente();

        private bool Validacion()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("El campo de nombres está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtId.Focus();
                return true;
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("El campo de apellidos está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                return true;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo de documento está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return true;
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("El campo de correo está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDireccion.Focus();
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
                foreach (DataGridViewRow row in Grilla.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void CrearCliente()
        {
            //Cliente cliente = new Cliente();

            //cliente.Nombres = txtId.Text.ToUpperInvariant();
            //cliente.Apellidos = txtApellido.Text.ToUpperInvariant();
            //cliente.Documento = txtNombre.Text.ToUpperInvariant();
            //cliente.Direccion = txtDIreccion.Text.ToUpperInvariant();


            //Random numeroRandom = new Random();
            //cliente.Id = numeroRandom.Next(0, 1000000);

            //clienteImpl.Agregar(cliente);
            //Grilla.DataSource = null;
            ////Grilla.DataSource = clienteImpl.Listar();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
        }

        private void AgregarCliente()
        {

            //if (BtnAgregar.Text == "Agregar")
            //{
            //    try
            //    {
            //        if (Validacion() == true)
            //        {

            //        }
            //        else
            //        {
            //            DialogResult resultado = MessageBox.Show("Desea agregar el cliente "
            //            + txtId.Text.ToUpperInvariant() + " " + txtApellido.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //            if (resultado == DialogResult.Yes)
            //            {
            //                bool clienteExistente = false;

            //                foreach (var item in clienteImpl.Listar())
            //                {
            //                    if (item.Documento.ToString() == txtNombre.Text.ToUpperInvariant())
            //                    {
            //                        clienteExistente = true;
            //                        break;
            //                    }
            //                }

            //                if (clienteExistente)
            //                {
            //                    MessageBox.Show("Ya existe un clienter con el documento " + txtNombre.Text.ToUpperInvariant()
            //                        + " registrado.", "Mensaje del sistema",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //                else
            //                {
            //                    CrearCliente();
            //                    LimpiarCampos();

            //                    MessageBox.Show("Cliente creado exitosamente.", "Mensaje del sistema",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //            }
            //            else
            //            {

            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    //ModificarCategoria();
            //}
        }

        private void EliminarCliente()
        {
            //try
            //{
            //    DialogResult resultado = MessageBox.Show("Desea eliminar el cliente "
            //    + Grilla[1, posicion].Value + " del registro?", "Mensaje del sistema",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (resultado == DialogResult.Yes)
            //    {
            //        //clienteImpl.Eliminar(clienteImpl.Listar()[posicion]);
            //        MessageBox.Show("Cliente eliminado correctamente.", "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        Grilla.DataSource = null;
            //    //    Grilla.DataSource = clienteImpl.Listar();
            //    //}
            //    else
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Mensaje del sistema",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }


        private void FrmCliente_Load(object sender, EventArgs e)
        {
            logicaCliente.CargarDatos(Grilla);
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarBusqueda();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Nombres = txtNombre.Text;
            cliente.Apellidos = txtApellido.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtEmail.Text;

            logicaCliente.Actualizar(cliente);
            if (!logicaCliente.Actualizar(cliente))
            {
                MessageBox.Show("No se actualizó el cliente");
            }
            else { MessageBox.Show("Cliente actualizado correctamente"); }
            logicaCliente.CargarDatos(Grilla);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnElimna_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Ingrese el id del cliente que desea elimiar.");
                    txtId.Select();
                }
                else
                {
                    logicaCliente.Eliminar(Convert.ToInt32(txtId.Text));
                    if (!logicaCliente.Eliminar(Convert.ToInt32(txtId.Text)))
                    {
                        MessageBox.Show("No se eliminó el cliente");
                    }
                    else { MessageBox.Show("Si eliminó el cliente correctamente."); }
                    logicaCliente.CargarDatos(Grilla);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombres = txtNombre.Text;
            cliente.Apellidos = txtApellido.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtEmail.Text;

            logicaCliente.Insertar(cliente);

            Grilla.DataSource = null;
            logicaCliente.CargarDatos(Grilla);
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
