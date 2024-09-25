using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class Pentagono : Poligono
    {
        public Pentagono(string nombre, float lado, float apotema) : base(nombre, lado, apotema)
        {
            numLados = 5;
        }

        ~Pentagono()
        {
            Console.WriteLine("\nSoy el destructor del pentágono, byeee (╯°□°）╯︵ ⬟\n");
        }
    }
}
