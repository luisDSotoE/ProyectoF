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

    public partial class InicioSesion : Form

    {

        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=proyecto;USER ID = proyecto ");
        public InicioSesion()
        {
            InitializeComponent();
        }

        private string usuario = "admin";
        private string contraseña = "admin";

        private void ValidarCredenciales()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("El campo del usuario está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("El campo de la contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
            }
            else
            {
                if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
                {
                    this.Hide();
                    Programa programa = new Programa();
                    programa.Show();
                }
                else
                {
                    MessageBox.Show("Las credenciales son incorrectas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
            }
        }

        //private void ValidarCredenciales()
        //{
        //    //try
        //    //{
        //    //    Usuario usuario = new L_Usuario().CargarDatos().Where(u => u.NombreUsuario == txtUsuario.Text
        //    //    && u.Contraseña == txtContraseña.Text).FirstOrDefault();

        //    //    if (txtUsuario.Text == "")
        //    //    {
        //    //        MessageBox.Show("El campo del nombre de usuario está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //        txtUsuario.Focus();
        //    //    }
        //    //    else if (txtContraseña.Text == "")
        //    //    {
        //    //        MessageBox.Show("El campo de contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //        txtContraseña.Focus();
        //    //    }
        //    //    else
        //    //    {
        //    //        if (usuario != null)
        //    //        {

        //    //            if (usuario.TipoUsuario == "Administrador")
        //    //            {
        //    //                this.Hide();
        //    //                FrmPanelAdministrador panelAdministrador = new FrmPanelAdministrador();
        //    //                panelAdministrador.Show();

        //    //            }
        //    //            if (usuario.TipoUsuario == "Cliente")
        //    //            {
        //    //                this.Hide();
        //    //                FrmPanelCompra panelCliente = new FrmPanelCompra(usuario);
        //    //                panelCliente.Show();
        //    //            }
        //    //        }
        //    //        else
        //    //        {
        //    //            MessageBox.Show("Credenciales incorrectas, verifique e intentelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    //        }
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //}
        //}
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //ValidarCredenciales();
            ora.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM INICIOSECCION WHERE USUARIO = :usuario AND CONTRASEÑA = :contra", ora);

            comando.Parameters.AddWithValue(":usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue(":contra", txtContraseña.Text);

            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                Programa Formulario = new Programa();

                ora.Close();
                this.Hide();
                Formulario.Show();
            }
            else
            {
                MessageBox.Show("no se pudo ingresar");
            }
            ora.Close();



        }


        private void InicioSesion_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
