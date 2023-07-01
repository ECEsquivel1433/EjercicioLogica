
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Libro
    {
        private string titulo;
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
        //funcion para agregar todo a un string
        public string ToString(string titulo, string autor, int año)
        {
            string result = " ";
            result = titulo + " " + autor + " " + año.ToString();
            return result;
        }
    }
    public class Biblioteca
    {
        //Se instancia la lista
        private List<object> Libros;

        public Biblioteca()
        {
            Libros = new List<object>();
        }
        //Se recibe el objeto y se manda a la funcion agregar
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

    //Metodo llamado para imprimir libros uno a uno
        public void MostrarLibros()
        {
            foreach(Libro libro in Libros)
            {
                Console.WriteLine(libro.Titulo + libro.Autor + libro.Año);
            }
        }
    }

 public class Program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        
        Libro libro1 = new Libro("Don Quijote de la mancha, ", "Miguel de cervantez ,", 1605);
        Libro libro2 = new Libro("Cien años de soledad ,", "Gabriel Garcia ,", 1967);
        Libro libro3 = new Libro("El codigo Da Vinci ,", "Dan Brown ,", 2003);
        Libro libro4 = new Libro("Guerra y paz ,", "Leon Tolsoi ,", 1867);
        Libro libro5 = new Libro("El Alquimista ,", "Paulo Coelho ,", 1988);

        //Llamar a la funcion para agregar los objetos enduro
        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);
        biblioteca.AgregarLibro(libro3);
        biblioteca.AgregarLibro(libro4);
        biblioteca.AgregarLibro(libro5);

        Console.WriteLine("Libros: ");
        //Llamar a la funcion para mostrar libros 1 a 1
        biblioteca.MostrarLibros();
        Console.ReadKey();

        
    }
}