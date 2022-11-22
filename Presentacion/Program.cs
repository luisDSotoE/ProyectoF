using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StreamWriter clientes = new StreamWriter("clientes.txt",true);
            clientes.Close();

            StreamWriter producto = new StreamWriter("Productos.txt", true);
            producto.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularios.InicioSesion());
        }
    }
}
