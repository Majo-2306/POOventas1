using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOventas1
{
    public class VentaCredito : Venta //Herencia
    {
        public VentaCredito(double monto) : base(monto) { }

        public override double CalcularTotal()
        {
            return monto * 1.05; // Incremento del 5% en ventas a credito
        }
    }
}
