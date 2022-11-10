using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        public string NombreUsuario { get; set; }  
        public string Contraseña { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{NombreUsuario}";
        }
    }
}
