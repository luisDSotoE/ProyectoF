using Datos;
using Entidades;
using System.Collections.Generic;
using System;

namespace Negocio
{
    public class ServicioProductoImpl
    {
        List<Producto> Productos;
        RepoProducto reposProductos;

        public ServicioProductoImpl()
        {
            reposProductos = new RepoProducto("Productos.txt");
            Productos = reposProductos.GetProductos();
        }

        public bool Actualizar(Producto Producto)
        {
            try
            {
                foreach (var item in Productos)
                {
                    if (item.Equals(Producto.Nombre))
                    {
                        item.Id = Producto.Id;
                        item.Nombre = Producto.Nombre;
                        item.Tipo = Producto.Tipo;
                        item.PrecioVenta = Producto.PrecioVenta;
                        item.PrecioCompra = Producto.PrecioCompra;
                        item.Minimo = Producto.Minimo;
                        item.Maximo = Producto.Maximo;
                        item.Codigo = Producto.Codigo;
                        break;
                    }
                }
                reposProductos.Update(Productos, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Agregar(Producto Producto)
        {
            try
            {
                reposProductos.GuardarDatos(Producto);
                Productos = reposProductos.GetProductos();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Eliminar(Producto Producto)
        {
            try
            {
                Productos.Remove(Producto);
                reposProductos.Update(Productos, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Producto> Listar()
        { return Productos; }
    }
}
