namespace Entidades
{
    /// <summary>
    /// Representa una persona
    /// </summary>
    public class Persona
    {
        ///<value>Propiedad Id correspondiente a Persona</value>
        public int Id { get; set; }
        ///<value>Propiedad Nombres correspondiente a Persona</value>
        public string Nombres { get; set; }
        ///<value>Propiedad Apellidos correspondiente a Persona</value>
        public string Apellidos { get; set; }
        ///<value>Propiedad Documento correspondiente a Persona</value>
        public string Documento { get; set; }
        ///<value>Propiedad Direccion correspondiente a Persona</value>
        public string Direccion { get; set; }
        ///<value>Propiedad Telefono correspondiente a Persona</value>
        public string Telefono { get; set; }
        ///<value>Propiedad Correo correspondiente a Persona</value>
        public string Correo { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return $"{Id};{Nombres};{Apellidos};{Documento};{Direccion};";
        }
    }
}
