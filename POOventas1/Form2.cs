using POOventas1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOventas1
{
    public partial class Form2 : Form //Herencia
    {
        private List<Venta> ventas = new List<Venta>();//Este es un encapsulamiento de nuestra lista de ventas

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) //este ejecuta el formulario
        {

        }

        private void btnCalcular_Click_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text); //Este nos convierte el texto a número
            Venta venta; //Polimorfismo

            if (rbContado.Checked)
                venta = new VentaContado(monto); //De venta se crea una nueva instacia que es new VentaContado y lo mismo pasa con new VentaCredito
            else
                venta = new VentaCredito(monto);

            ventas.Add(venta); //Agregar ventas
            ActualizarGrid(); 
        }
        private void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ventas.ConvertAll(v => new { Tipo = v.GetType().Name, Monto = v.Monto, Total = v.CalcularTotal() }); //Metodo de manipulación, comvierte los datos capturados a un formato legible.
        }
        public abstract class Venta //Clase Abstracta 
        {
            protected double monto; // Encapsulamiento

            public Venta(double monto)
            {
                this.monto = monto;
            }

            public double Monto { get { return monto; } } //Encapsulamiento

            public abstract double CalcularTotal(); // Metodo abstracto CalcularTotal
        }

        public class VentaContado : Venta //Herencia 
        {
            public VentaContado(double monto) : base(monto) { }

            public override double CalcularTotal()
            {
                return monto;
            }
        }

        public class VentaCredito : Venta //Herencia
        {
            public VentaCredito(double monto) : base(monto) { }

            public override double CalcularTotal()
            {
                return monto * 1.05; // Incremento del 5% en ventas a credito
            }
        }
    }
}


   

