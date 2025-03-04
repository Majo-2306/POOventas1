using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOventas1
{
    public class VentaContado : Venta //Herencia 
    {
        public VentaContado(double monto) : base(monto) { }

        public override double CalcularTotal()
        {
            return monto; //Este manda el monto original sin ningun incremento
        }
    }
}
