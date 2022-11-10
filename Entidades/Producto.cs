using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public string Codigo { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Tipo};{PrecioVenta};{Minimo};{Maximo};{Codigo}";
        }
    }
}
