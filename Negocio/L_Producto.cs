using Datos;
using Entidades;
using System.Windows.Forms;

namespace Negocio
{
    /// <summary>
    /// clase producto en logica
    /// </summary>
    public class L_Producto
    {
        /// <summary>
        /// Declaracion d onjetos DatosProductos
        /// </summary>
        D_Producto datosProducto = new D_Producto();
        /// <summary>
        /// Llama al metodo de insertar en factura
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Retorna una cadena con nuevos datos</returns>
        public bool Insertar(Producto producto)
        {
            return datosPorducto.Insertar(producto);
        }
        /// <summary>
        /// Llama al metodo de CargarDatos en producto
        /// </summary>
        /// <param name="grilla"></param>
        /// <returns>Retorna datos de la base de datos</returns>
        public bool CargarDatos(DataGridView grilla)
        {
            return datosPorducto.CargarDatos(grilla);
        }
        /// <summary>
        /// LLama al metodo eliminar en producto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>elimina una cadena de datos seleccionado</returns>
        public bool Eliminar(int idProducto)
        {
            return datosPorducto.Eliminar(idProducto);
        }
        /// <summary>
        /// llama al metodo actualizar de producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Modifica una cadena de la base de datos</returns>
        public bool Actualizar(Producto producto)
        {
            return datosPorducto.Actualizar(producto);
        }
    }
}
