namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public double Stock { get; set; }
        public double Id_factura { get; set; }
   

        public override string ToString()
        {
            return $"{Id};{Nombre};{Precio};{Stock};{Id_factura}";
        }
    }
}
