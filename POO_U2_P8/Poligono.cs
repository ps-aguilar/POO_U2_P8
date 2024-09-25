using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class Poligono : FiguraGeometrica
    {
        protected float lado;
        protected float apotema;
        protected int numLados;
        public Poligono(string nombre, float lado, float apotema) : base(nombre)
        {
            this.lado = lado;
            this.apotema = apotema;
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
