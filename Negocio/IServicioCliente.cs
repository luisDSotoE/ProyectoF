using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface IServicioCliente
    {
        bool Agregar(Cliente cliente);
        bool Eliminar(Cliente cliente);
        bool Actualizar(Cliente cliente);
        List<Cliente> Listar();
    }
}
