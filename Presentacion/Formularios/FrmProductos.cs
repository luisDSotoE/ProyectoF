using DocumentFormat.OpenXml.Wordprocessing;
using Entidades;
using Negocio;
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmProductos : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
        public FrmProductos()
        {
            InitializeComponent();
        }

        //public static ServicioProductoImpl productoImpl = new ServicioProductoImpl();
        int posicion = 0;

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //Grilla.DataSource = productoImpl.Listar();
        }

        private bool Validacion()
        {
            if (txtIdp.Text == "")
            {
                MessageBox.Show("El campo de nombre está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdp.Focus();
                return true;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo de tipo está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return true;
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("El campo de compra está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return true;
            }
            else if (txtStock.Text == "")
            {
                MessageBox.Show("El campo de venta está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStock.Focus();
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
                //Grilla.DataSource = productoImpl.Listar();
            }
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarBusqueda();
        }

        private void CrearProducto()
        {
            //try
            //{
            //    Producto producto = new Producto();
            //    Random numeroRandom = new Random();
            //    producto.Id = numeroRandom.Next(0, 1000000);
            //    producto.Nombre = txtIdp.Text.ToUpperInvariant();
            //    producto.Tipo = txtNombre.Text.ToUpperInvariant();
            //    producto.Precio = double.Parse(txtPrecio.Text.ToUpperInvariant());
            //    producto.Stock = double.Parse(txtStock.Text.ToUpperInvariant());


            //    productoImpl.Agregar(producto);
            //    Grilla.DataSource = null;
            //    //Grilla.DataSource = productoImpl.Listar();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Mensaje del sistema",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LimpiarCampos()
        {
            txtIdp.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

        }

        private void AgregarProducto()
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
            //            DialogResult resultado = MessageBox.Show("Desea agregar el producto "
            //            + txtIdp.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //            if (resultado == DialogResult.Yes)
            //            {
            //                bool ProductoExistente = false;

            //                foreach (var item in productoImpl.Listar())
            //                {
            //                    if (item.Codigo.ToString() == txtIdp.Text.ToUpperInvariant())
            //                    {
            //                        ProductoExistente = true;
            //                        break;
            //                    }
            //                }

            //                if (ProductoExistente)
            //                {
            //                    MessageBox.Show("Ya existe un producto con el codigo " + txtIdp.Text.ToUpperInvariant()
            //                        + " registrado.", "Mensaje del sistema",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //                else
            //                {
            //                    CrearProducto();
            //                    LimpiarCampos();

            //                    MessageBox.Show("Producto creado exitosamente.", "Mensaje del sistema",
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

        private void EliminarProducto()
        {
            //try
            //{
            //    DialogResult resultado = MessageBox.Show("Desea eliminar el Producto "
            //    + Grilla[1, posicion].Value + " del registro?", "Mensaje del sistema",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (resultado == DialogResult.Yes)
            //    {
            //        productoImpl.Eliminar(productoImpl.Listar()[posicion]);
            //        MessageBox.Show("Producto eliminado correctamente.", "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        Grilla.DataSource = null;
            //        Grilla.DataSource = productoImpl.Listar();
            //    }
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
            AgregarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (productoImpl.Listar().Count == 0)
            //{
            //    MessageBox.Show("No hay Productos registrados.", "Mensaje del sistema",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    if (posicion < 0)
            //    {
            //        MessageBox.Show("Seleccione un registro.", "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        EliminarProducto();
            //    }
            //}
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarPRODUCTO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Grilla.DataSource = tabla;
        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
                ora.Open();
                OracleCommand comando = new OracleCommand("Actualizar3", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIdp.Text);
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("precio", OracleType.Number).Value = Convert.ToInt32(txtPrecio.Text);
                comando.Parameters.Add("stock", OracleType.Number).Value = Convert.ToInt32(txtStock.Text);
                comando.Parameters.Add("idf", OracleType.Number).Value = Convert.ToInt32(txtIdf.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("PRODUCTO actualizada");
                ora.Close();

            }
            catch (Exception ex)
            {
                ora.Close();

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ora.Close();
        }

        private void btnEliminado_Click(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=factura;USER ID = factura ");
            ora.Open();
            OracleCommand comando = new OracleCommand("eliminar3", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIdp.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            ora.Close();
        }

        private void txtIdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
