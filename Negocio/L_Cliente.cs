using Datos;
using Entidades;
using System.Windows.Forms;

namespace Negocio
{
    public class L_Cliente
    {
        D_Cliente datosClientes = new D_Cliente();

        public bool Insertar(Cliente cliente)
        {
            return datosClientes.Insertar(cliente);
        }
    
        public bool CargarDatos(DataGridView grilla)
        {
            return datosClientes.CargarDatos(grilla);
        }
    
        public bool Eliminar(int idCliente)
        {
            return datosClientes.Eliminar(idCliente);   
        }
    
        public bool Actualizar(Cliente cliente)
        {
            return datosClientes.Actualizar(cliente);
        }
    }
}

