using Entidades;
using System.Collections.Generic;
using System.IO;
using System;

namespace Datos
{
    public class RepoProducto : ArchProducto
    {
        public RepoProducto() : base()
        {
        }

        public RepoProducto(string ruta) : base(ruta)
        {
        }

        public List<Producto> GetProductos()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Producto> productos = new List<Producto>();
                while (!sr.EndOfStream)
                {
                    productos.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return productos;
            }
            catch (Exception e) { throw e; }
        }

        public Producto Mappear(string cadena)
        {
            try
            {
                Producto Producto = new Producto();
                Producto.Id = int.Parse(cadena.Split(';')[0]);
                Producto.Nombre = cadena.Split(';')[1];
                Producto.Tipo = cadena.Split(';')[2];
                Producto.PrecioVenta = double.Parse(cadena.Split(';')[3]);
                Producto.PrecioCompra = double.Parse(cadena.Split(';')[4]);
                Producto.Minimo = int.Parse(cadena.Split(';')[5]);
                Producto.Maximo = int.Parse(cadena.Split(';')[6]);
                Producto.Codigo = cadena.Split(';')[7];
                return Producto;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Producto> Productos, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in Productos) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}

