using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class Rectangulo : FiguraGeometrica
    {
        private float _base;
        private float altura;
        public Rectangulo(string nombre, float _base, float altura) : base(nombre)
        {
            this._base = _base;
            this.altura = altura;
        }
        public override float CalcularArea()
        {
            return _base * altura;
        }

        public override float CalcularPerimetro()
        {
            return (2 * _base) + (2 * altura);
        }
    }
}
