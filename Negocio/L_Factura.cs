using Datos;
using Entidades;
using System.Windows.Forms;

namespace Negocio
{
    /// <summary>
    /// Clase Factura en logica
    /// </summary>
    public class L_Factura
    {
        /// <summary>
        /// Declaracion de objeto DatosFactura
        /// </summary>
        D_Factura datosFactura = new D_Factura();
        /// <summary>
        /// Llama el metodo de insertar de Factura
        /// </summary>
        /// <param name="Factura"></param>
        /// <returns>Retornad datos insertados</returns>
        public bool Insertar(Factura Factura)
        {
            return datosFactura.Insertar(Factura);
        }
        /// <summary>
        /// Llama al metodo de cargarDatos en factura
        /// </summary>
        /// <param name="grilla"></param>
        /// <returns>Retorna una cadena de datos</returns>
        public bool CargarDatos(DataGridView grilla)
        {
            return datosFactura.CargarDatos(grilla);
        }
        /// <summary>
        /// LLama al meotodo eliminar de facutra
        /// </summary>
        /// <param name="idFactura"></param>
        /// <returns>Elimina una cadena de datos seleccionada</returns>
        public bool Eliminar(int idFactura)
        {
            return datosFactura.Eliminar(idFactura);
        }
        /// <summary>
        /// LLama el metodo de Actualizar en factura
        /// </summary>
        /// <param name="Factura"></param>
        /// <returns>Retorna los datos modificados de la tabla</returns>
        public bool Actualizar(Factura Factura)
        {
            return datosFactura.Actualizar(Factura);
        }
    }
}
