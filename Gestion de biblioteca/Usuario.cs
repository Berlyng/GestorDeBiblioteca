using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_biblioteca
{
    internal class Usuario
    {
        private string nombre;
        private List<Libro> librosPrestados;

        public Usuario() 
        { 
            nombre = string.Empty;
            librosPrestados = new List<Libro>();
        }

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get { return nombre; } }
        public List<Libro> Libros { get {  return librosPrestados; } }


    }
}
