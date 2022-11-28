using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa una Venta
    /// </summary>
    public class Venta
    {
        ///<value>Propiedad Id correspondiente a venta</value>
        public int Id { get; set; }
        ///<value>Propiedad Numero correspondiente a venta</value>
        public int Numero { get; set; }
        ///<value>Propiedad Cliente correspondiente a venta</value>
        public Cliente Cliente { get; set; }
        ///<value>Propiedad Usuario correspondiente a venta</value>
        public Usuario Usuario { get; set; }
        ///<value>Propiedad FechaVenta correspondiente a venta</value>
        public DateTime FechaVenta { get; set; }
        ///<value>Propiedad Total correspondiente a venta</value>
        public double Total { get; set; }
        ///<value>Propiedad Subtotal correspondiente a Venta</value>
        public double SubTotal { get; set; }
        ///<value>Propiedad Descuento correspondiente a Venta</value>
        public double Descuento { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return $"{Id};{Numero};{Cliente};{Usuario};{FechaVenta};{Total};{SubTotal};{Descuento}";
        }

    }
}
