using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa un adminstrador que hereda de persona
    /// </summary>
    public class Administrador : Persona
    {
        /// <value>Usuario que se implementara para el login</value>
        public string UsuarioAdministrador { get; set; }
        /// <value>contraseña utilizada para el login</value>
        public string contraseña { get; set; }
        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return base.ToString() + $"{UsuarioAdministrador}";
        }
    }
}
