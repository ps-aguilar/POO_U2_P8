using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class Triangulo : FiguraGeometrica
    {
        private float _base;
        private float altura;
        private float ladoB;
        private float ladoC;

        public Triangulo(string nombre, float _base, float ladoB, float ladoC, float altura) : base(nombre)
        {
            this._base = _base;  
            this.ladoB = ladoB;
            this.ladoC = ladoC;
            this.altura = altura;
        }

        ~Triangulo()
        {
            Console.WriteLine("\nSoy el destructor del triángulo, byeee (╯°□°）╯︵ △\n");
        }

        public override float CalcularArea()
        {
            return (_base * altura) / 2F; 
        }

        public override float CalcularPerimetro()
        {
            return _base + ladoB + ladoC; 
        }
    }
}
