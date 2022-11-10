using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Persona
    {
        public string UsuarioAdministrador { get; set; }
        public string contraseña { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{UsuarioAdministrador}";
        }
    }
}
