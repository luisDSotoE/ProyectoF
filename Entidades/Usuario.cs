using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa un Usuario
    /// </summary>
    public class Usuario : Persona
    {
        ///<value>Propiedad NombreUsuario correspondiente a Usuario</value>
        public string NombreUsuario { get; set; }
        ///<value>Propiedad Contraseña correspondiente a Usuario</value>
        public string Contraseña { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return base.ToString() + $"{NombreUsuario}";
        }
    }
}
