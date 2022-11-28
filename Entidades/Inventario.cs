using System;

namespace Entidades
{
    /// <summary>
    /// Representa una Inventario
    /// </summary>
    public class Inventario
    {
        ///<value>Propiedad Id correspondiente a Inventario</value>
        public int Id { get; set; }
        ///<value>Propiedad Producto correspondiente a Inventario</value>
        public string Producto { get; set; }
        ///<value>Propiedad Cantidad correspondiente a Inventario</value>
        public int Cantidad { get; set; }
        ///<value>Propiedad Almacen correspondiente a Inventario</value>
        public int Almacen { get; set; }
        ///<value>Propiedad Tipo correspondiente a Inventario</value>
        public int Tipo { get; set; }
        ///<value>Propiedad FechaInventario correspondiente a Inventario</value>
        public DateTime FechaInventario { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return $"{Id};{Producto};{Cantidad};{Almacen};{Tipo};{FechaInventario}";
        }
    }
}
