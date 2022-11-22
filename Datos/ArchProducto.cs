using Entidades;
using System.Collections.Generic;
using System.IO;
using System;

namespace Datos
{
    public class ArchProducto
    {
        protected string ruta = "Productos.txt";

        public ArchProducto()
        {
            this.ruta = "Productos.txt";
        }

        public ArchProducto(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Producto Producto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(Producto.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Producto> producto)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in producto) { sw.WriteLine(item); }
                sw.Close();
                File.Delete(ruta);
                File.Move("temporal", ruta);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public void vaciar()
        {
            StreamWriter sw = new StreamWriter(ruta, false);
            sw.Write("");
            sw.Close();
        }
    }
}
