using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class L_Categoria
    {
        D_Categoria datosCategoria = new D_Categoria();

        /// <summary>
        /// LLama al metodo insertar de Categoria
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns>Retorna Datos insertados</returns>
        public bool Insertar(Categoria Categoria)
        {
            return datosCategoria.Insertar(Categoria);
        }

        public bool CargarDatos(DataGridView grilla)
        {
            return datosCategoria.CargarDatos(grilla);
        }

        /// <summary>
        /// Llama el metodo Eliminar en Categoria
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <returns>Elimina una cadena de la base de datoss</returns>
        public bool Eliminar(int idCategoria)
        {
            return datosCategoria.Eliminar(idCategoria);
        }

        /// <summary>
        /// LLama metodo de Actualizar de Categoria
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns>Retorna Datos modificados</returns>
        public bool Actualizar(Categoria Categoria)
        {
            return datosCategoria.Actualizar(Categoria);
        }/// <summary>
        /// LLama al metodo insertar de Categoria
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns>Retorna Datos insertados</returns>
        
    }
}
