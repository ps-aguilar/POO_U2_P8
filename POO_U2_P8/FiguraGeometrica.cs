using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class FiguraGeometrica
    {
        private string nombre;

        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
        }

        public virtual float CalcularArea()
        {
            return 0.0F;
        }
        public virtual float CalcularPerimetro()
        {
            return 0.0F;
        }
    }
}
