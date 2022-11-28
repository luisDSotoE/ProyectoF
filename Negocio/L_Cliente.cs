using Datos;
using Entidades;
using System.Windows.Forms;

namespace Negocio
{ 
    /// <summary>
    /// Clase cliente en logica
    /// </summary>
    public class L_Cliente

    {
        /// <summary>
        /// Declaracion de objeto Datoscliente
        /// </summary>
        D_Cliente datosClientes = new D_Cliente();
        
        /// <summary>
        /// LLama al metodo insertar de cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Retorna Daotos insertados</returns>
        public bool Insertar(Cliente cliente)
        {
            return datosClientes.Insertar(cliente);
        }
        
        /// <summary>
        /// Llama al metodo cargarDatos de cliente
        /// </summary>
        public bool CargarDatos(DataGridView grilla)
        {
            return datosClientes.CargarDatos(grilla);
        }
        
        /// <summary>
        /// Llama el metodo Eliminar en Cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Elimina una cadena de la base de datoss</returns>
        public bool Eliminar(int idCliente)
        {
            return datosClientes.Eliminar(idCliente);   
        }
        
        /// <summary>
        /// LLama metodo de Actualizar de CLiente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Retorna Datps modificados</returns>
        public bool Actualizar(Cliente cliente)
        {
            return datosClientes.Actualizar(cliente);
        }
    }
}

