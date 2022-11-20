using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private string usuario = "admin";
        private string contraseña = "admin";

        private void ValidarCredenciales()
        {
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("El campo del usuario está vacío.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUsuario.Focus();
            } else if(txtContraseña.Text == "")
            {
                MessageBox.Show("El campo de la contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
            }
            else
            {
                if(txtUsuario.Text =="admin" && txtContraseña.Text == "admin")
                {
                    this.Hide();
                    Programa programa = new Programa();
                    programa.Show();
                }
                else
                {
                    MessageBox.Show("Las credenciales son incorrectas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
