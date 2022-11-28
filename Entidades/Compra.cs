using System;

namespace Entidades
{
    /// <summary>
    /// Representa una compra
    /// </summary>
    public class Compra
    {
        ///<value>Propiedad Id correspondiente a Compra</value>
        public int Id { get; set; }
        ///<value>Propiedad Numero correspondiente a Compr</value>
        public int Numero { get; set; }
        ///<value>Propiedad Usuario correspondiente a Compr</value>
        public Usuario Usuario { get; set; }
        ///<value>Propiedad FechaCompra correspondiente a Compr</value>
        public DateTime FechaCompra { get; set; }
        ///<value>Propiedad Total correspondiente a Compr</value>
        public double Total { get; set; }
        ///<value>Propiedad Subtotal correspondiente a Compr</value>
        public double SubTotal { get; set; }
        ///<value>Propiedad DEscuento correspondiente a Compr</value>
        public double Descuento { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return $"{Id};{Numero};{Usuario};{FechaCompra};{Total};{SubTotal};{Descuento}";
        }
    }
}
