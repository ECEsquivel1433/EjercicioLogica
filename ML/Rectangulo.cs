using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Rectangulo
    {
        private double Longitud;
        private double Ancho;

        public Rectangulo () {
            Longitud= 0;
            Ancho= 0;
        }
        public Rectangulo(double Longitud, double Ancho)
        {
            Longitud = 2;
            Ancho = 2;
        }

        public double CalcularArea(double Longitud, double Ancho)
        {   
            return (Longitud * Ancho);
        }

    }
    
}
