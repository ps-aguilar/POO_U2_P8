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

        ~Hexagono()
        {
            Console.WriteLine("\nSoy el destructor del hexágono, byeee (╯°□°）╯︵ ⬢\n");
        }
    }
}
