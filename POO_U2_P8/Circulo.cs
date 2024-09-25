using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class Circulo : FiguraGeometrica
    {
        private float radio;
        public Circulo(string nombre, float radio) : base(nombre) 
        {
            this.radio = radio;
        }
        ~Circulo()
        {
            Console.WriteLine("\nSoy el destructor del circulo, byeee (╯°□°）╯︵ ⭕\n");
        }
        public override float CalcularArea()
        {
            return float.Pi * (radio * radio);
        }

        public override float CalcularPerimetro()
        {
            return 2F * float.Pi * radio;
        }
    }
}
