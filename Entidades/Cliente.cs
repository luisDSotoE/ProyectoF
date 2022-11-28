namespace Entidades
{
    /// <summary>
    /// Representa un cliente 
    public class Cliente : Persona
    {
        ///<value>Propiedad de cliente correspondiente a tipos de cliente</value>
        public string TipoCliente { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return base.ToString() + $"{TipoCliente}";
        }
    }
}
