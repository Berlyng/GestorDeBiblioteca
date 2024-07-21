using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Usuario> usuarios;

        public Biblioteca() 
        {
            libros = new List<Libro>();
            usuarios = new List<Usuario>();
        }

        public void AgregarLibro (Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine($"libro {libro.Titulo} agregado a la biblioteca ");
        }

        public void AgregarUsuario (Usuario usuario)
        {
            usuarios.Add(usuario);
            Console.WriteLine($"Usuario {usuario.Nombre} agregado con exito");
        }

        public Libro BuscarLibroPorTitulo(string titulo)
        {
            return libros.FirstOrDefault(libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

        }

        public Libro BuscarLibroPorAutor(string autor)
        {
            return libros.FirstOrDefault(libro => libro.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase));
        }

        public Libro BuscarLibroPorIsbn (string isbn)
        {
            return libros.FirstOrDefault(libro => libro.Isbn.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        public void PrestarLibro(string tituo, Usuario usuario)
        {
            var libro = BuscarLibroPorTitulo (tituo);
            if (libro == null && libro.Disponibilidad)
            {
                libro.prestar();
                usuario.Libros.Add(libro);
                Console.WriteLine($"El libro {libro.Titulo} fue prestado con exito a {usuario.Nombre}");
            }else 
            {
                Console.WriteLine($"El libro {libro.Titulo} no esta disponible para prestar");

            }
        }

        public void DevolverLibro (string titulo,  Usuario usuario)
        {
           
            var libro = usuario.Libros.FirstOrDefault(t => t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro == null)
            {
                libro.devolver();
                Console.WriteLine($"El libro {libro.Titulo} fue devuelto con exito por {usuario.Nombre}");
            }
            else
            {
                Console.WriteLine($"el {usuario.Nombre} no tiene el libro {libro.Titulo}");
            }

        }

        public void MostrarLibrosDisponibles()
        {
            Console.WriteLine("Libros disponibles:");
            foreach (var libro in libros)
            {
                if (libro.Disponibilidad)
                {
                    Console.WriteLine($"- {libro.Titulo} por {libro.Autor}");
                }
            }
        }
    }


}
