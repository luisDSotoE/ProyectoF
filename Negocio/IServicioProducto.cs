using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
