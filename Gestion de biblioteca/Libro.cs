using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_biblioteca
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string isbn;
        private bool disponibilidad;

        public void prestar()
        {
            disponibilidad = false;
        }

        public void devolver()
        {
            disponibilidad |= true;
        }

        public Libro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;   
            Disponibilidad = true;
            Isbn = string.Empty;
        }

        public Libro(string titulo, string autor, string isbn)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Isbn = isbn;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string  Isbn { get => isbn; set => isbn = value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }


    }
}
