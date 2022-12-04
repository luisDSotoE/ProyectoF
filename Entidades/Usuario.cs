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
    public class Usuario
    {
        /// <summary>
        /// Obtiene o establece el identificador usuario.
        /// </summary>
        /// <value>
        /// El identificador usuario.
        /// </value>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el documento.
        /// </summary>
        /// <value>
        /// El documento.
        /// </value>
        public string Documento { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo.
        /// </summary>
        /// <value>
        /// El nombre completo.
        /// </value>
        public string Nombre { get; set; }
       
        public string Apellido { get; set; }

        /// <summary>
        /// Obtiene o establece el correo.
        /// </summary>
        /// <value>
        /// El correo.
        /// </value>
        public string Correo { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña.
        /// </summary>
        /// <value>
        /// La contraseña.
        /// </value>
        public string Contraseña { get; set; }

        /// <summary>
        /// Obtiene o establece el objeto rol.
        /// </summary>
        /// <value>
        /// The objeto rol.
        /// </value>
        public Rol ObJRol { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha de registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
