using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface IServicioProducto
    {
        bool Agregar(Producto producto);
        List<Producto> Listar();
        bool Actualizar(Producto producto, int posicionProducto);
        bool Eliminar(Producto producto, string IdProducto);
    }
}
