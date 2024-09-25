using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class Hexagono : Poligono
    {
        public Hexagono(string nombre, float lado, float apotema) : base(nombre, lado, apotema)
        {
            numLados = 6;
        }

        public override float CalcularArea()
        {
            return (CalcularPerimetro() * apotema) / 2;
        }

        public override float CalcularPerimetro()
        {
            return lado * numLados;
        }
    }
}
