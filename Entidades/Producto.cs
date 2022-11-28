namespace Entidades
{
    /// <summary>
    /// Representa un producto
    /// </summary>
    public class Producto
    {
        ///<value>Propiedad Id correspondiente a producto</value>
        public int Id { get; set; }
        ///<value>Propiedad Nombre correspondiente a producto</value>
        public string Nombre { get; set; }
        ///<value>Propiedad Precio correspondiente a producto</value>
        public string Precio { get; set; }
        ///<value>Propiedad Stock correspondiente a producto</value>
        public double Stock { get; set; }
        ///<value>Propiedad Id_factura correspondiente a producto</value>
        public double Id_factura { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>

        public override string ToString()
        {
            return $"{Id};{Nombre};{Precio};{Stock};{Id_factura}";
        }
    }
}
