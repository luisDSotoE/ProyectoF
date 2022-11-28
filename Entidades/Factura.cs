using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public string Fecha { get; set; }
        public int Id_Producto { get; set; }

        /// <summary>
        /// Convierte los datos a cadena
        /// </summary>
        /// <returns>Retorna una cadena</returns>
        public override string ToString()
        {
            return $"{Id};{Id_cliente};{Fecha};{Id_Producto}";
        }
    }
}

