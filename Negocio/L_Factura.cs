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
        D_Factura datosFactura = new D_Factura();

        public bool Insertar(Factura Factura)
        {
            return datosFactura.Insertar(Factura);
        }

        public bool CargarDatos(DataGridView grilla)
        {
            return datosFactura.CargarDatos(grilla);
        }

        public bool Eliminar(int idFactura)
        {
            return datosFactura.Eliminar(idFactura);
        }

        public bool Actualizar(Factura Factura)
        {
            return datosFactura.Actualizar(Factura);
        }
    }
}
