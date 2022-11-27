using Datos;
using Entidades;
using System.Windows.Forms;

namespace Negocio
{
    public class L_Producto
    {
        D_Producto datosPorducto = new D_Producto();
        
        public bool Insertar(Producto producto)
        {
            return datosPorducto.Insertar(producto);
        }

        public bool CargarDatos(DataGridView grilla)
        {
            return datosPorducto.CargarDatos(grilla);
        }

        public bool Eliminar(int idProducto)
        {
            return datosPorducto.Eliminar(idProducto);
        }

        public bool Actualizar(Producto producto)
        {
            return datosPorducto.Actualizar(producto);
        }
    }
}
