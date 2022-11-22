using Entidades;
using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        public static ServicioProductoImpl productoImpl = new ServicioProductoImpl();
        int posicion = 0;

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Grilla.DataSource = productoImpl.Listar();
        }

        private bool Validacion()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo de nombre está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return true;
            }
            else if (txtTipo.Text == "")
            {
                MessageBox.Show("El campo de tipo está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTipo.Focus();
                return true;
            }
            else if (txtCompra.Text == "")
            {
                MessageBox.Show("El campo de compra está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCompra.Focus();
                return true;
            }
            else if (txtVenta.Text == "")
            {
                MessageBox.Show("El campo de venta está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtVenta.Focus();
                return true;
            }
            else if (txtMin.Text == "")
            {
                MessageBox.Show("El campo de minimo está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMin.Focus();
                return true;
            }
            else if (txtMax.Text == "")
            {
                MessageBox.Show("El campo de maximo está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMax.Focus();
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
                Grilla.DataSource = productoImpl.Listar();
            }
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarBusqueda();
        }

        private void CrearProducto()
        {
            try
            {
                Producto producto = new Producto();
                Random numeroRandom = new Random();
                producto.Id = numeroRandom.Next(0, 1000000);
                producto.Nombre = txtNombre.Text.ToUpperInvariant();
                producto.Tipo = txtTipo.Text.ToUpperInvariant();
                producto.PrecioCompra = double.Parse(txtCompra.Text.ToUpperInvariant());
                producto.PrecioVenta = double.Parse(txtVenta.Text.ToUpperInvariant());
                producto.Minimo = int.Parse(txtMin.Text.ToUpperInvariant());
                producto.Maximo = int.Parse(txtMax.Text.ToUpperInvariant());
                producto.Codigo = txtCodigo.Text.ToUpperInvariant();

                productoImpl.Agregar(producto);
                Grilla.DataSource = null;
                Grilla.DataSource = productoImpl.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtCompra.Text = "";
            txtVenta.Text = "";
            txtMin.Text = "";
            txtMax.Text = "";
            txtCodigo.Text = "";
        }

        private void AgregarProducto()
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
                        DialogResult resultado = MessageBox.Show("Desea agregar el producto "
                        + txtNombre.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            bool ProductoExistente = false;

                            foreach (var item in productoImpl.Listar())
                            {
                                if (item.Codigo.ToString() == txtCodigo.Text.ToUpperInvariant())
                                {
                                    ProductoExistente = true;
                                    break;
                                }
                            }

                            if (ProductoExistente)
                            {
                                MessageBox.Show("Ya existe un producto con el codigo " + txtCodigo.Text.ToUpperInvariant()
                                    + " registrado.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                CrearProducto();
                                LimpiarCampos();

                                MessageBox.Show("Producto creado exitosamente.", "Mensaje del sistema",
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

        private void EliminarProducto()
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el Producto "
                + Grilla[1, posicion].Value + " del registro?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    productoImpl.Eliminar(productoImpl.Listar()[posicion]);
                    MessageBox.Show("Producto eliminado correctamente.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Grilla.DataSource = null;
                    Grilla.DataSource = productoImpl.Listar();
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
            AgregarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoImpl.Listar().Count == 0)
            {
                MessageBox.Show("No hay Productos registrados.", "Mensaje del sistema",
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
                    EliminarProducto();
                }
            }
        }
    }
}
