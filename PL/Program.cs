using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la longitud");
            double Longitud = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho");
            double Ancho = double.Parse(Console.ReadLine());

            
             ML. Rectangulo rectangulo = new ML.Rectangulo();
            double resultado = rectangulo.CalcularArea(Longitud, Ancho);
            
            Console.WriteLine("El area es: " + resultado);
            Console.ReadKey();
        }

    }
}