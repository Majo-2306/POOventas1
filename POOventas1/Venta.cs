using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOventas1
{
    public abstract class Venta //Clase abstracta
    {
        protected double monto; // Encapsulamiento
       
        public Venta(double monto)
        {
            this.monto = monto;
        }

        public double Monto { get { return monto; } } //Encapsulamiento

        public abstract double CalcularTotal(); // Metodo abstracto CalcularTotal
    }
}
