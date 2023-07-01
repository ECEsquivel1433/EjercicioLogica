using BLBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLBiblioteca
{
    public class Libro
    {
        private string titulo ;
        private string autor;
        private int año;

        public int Año { get { return año; } set { año = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }

        public Libro()
        {
            titulo = " ";
            autor = " ";
            año = 0;
        }
        public Libro(string titulo, string autor, int año)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.año = año;
        }

        public string ToString(string titulo, string autor, int año)
        {
            string result = " ";
            result = titulo + " " + autor + " " + año.ToString();
            return result;
        }
    }
    public class Biblioteca
    {
        private List<object> Libros;

        public Biblioteca()
        {
            Libros = new List<object>();
        }
        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }



        public List<Libro> BuscarLibroPorAutor(string autor)
        {
            List<Libro> librosencontrados = new List<Libro>();
            foreach(Libro libro in Libros)
            {
                if (libro.Autor.Equals(autor))
                {
                    librosencontrados.Add(libro);
                }
            }
            return librosencontrados;
        }


        public List<Libro> BuscarLibroPorAño(int año)
        {
            List<Libro> librosencontrados = new List<Libro>();
            foreach (Libro libro in Libros)
            {
                if (libro.Año.Equals(año))
                {
                    librosencontrados.Add(libro);
                }
            }
            return librosencontrados;
        }


        public void MostrarLibros()
        {
            foreach(Libro libro in Libros)
            {
                Console.WriteLine(libro);
            }
        }
    }
}
 public class Program
{
    public static void Main(string[] args)
    {
        BLBiblioteca.Biblioteca biblioteca = new BLBiblioteca.Biblioteca();
        
        Libro libro1 = new Libro("Titulo1", "Autor1", 1996);
        Libro libro2 = new Libro("Titulo2", "Autor2", 1997);
        Libro libro3 = new Libro("Titulo3", "Autor3", 1998);

        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);
        biblioteca.AgregarLibro(libro3);

        Console.WriteLine("Libros: ");
        //Llamar a la funcion para mostrar libros 1 a 1
        biblioteca.MostrarLibros();
        Console.ReadKey();

        
    }
}