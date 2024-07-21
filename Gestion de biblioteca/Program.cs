using System;
using System.Runtime.InteropServices.ComTypes;

namespace Gestion_de_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Libro libro1 = new Libro("Cien Años de Soledad", "Gabriel Garcia Marquez", "123456789");
            Libro libro2 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", "987654321");

            biblioteca.AgregarLibro(libro1);
            biblioteca .AgregarLibro(libro2);


            Usuario usuario1 = new Usuario("Juan Perez");
            biblioteca.AgregarUsuario(usuario1);

            biblioteca.PrestarLibro("Cien Años de Soledad", usuario1);
            biblioteca.MostrarLibrosDisponibles();

            biblioteca.DevolverLibro("Cien Años de Soledad", usuario1);
            biblioteca.MostrarLibrosDisponibles();

            Console.ReadKey();
        }
    }
}
