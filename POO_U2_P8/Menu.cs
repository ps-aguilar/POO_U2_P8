using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P8
{
    internal class Menu
    {
        List<Opcion> opciones;
        FiguraGeometrica figura;
        public Menu()
        {
            opciones = new List<Opcion>()
            {
                new Opcion("Circulo", Circulo),
                new Opcion("Rectángulo", Rectangulo),
                new Opcion("Triángulo", Triangulo),
                new Opcion("Pentágono", Pentagono),
                new Opcion("Hexágono", Hexagono),
                new Opcion("Salir", Salir),
             };

            while (true)
            {
                Console.WriteLine("**Calculadora de Área y Perímetro**");
                Console.WriteLine("Seleccione la opción deseada:");
                Console.WriteLine();
                MostrarMenu();
                Console.WriteLine();
                seleccionarOpcion();
            }
        }

        ////
        public void MostrarMenu()
        {
            foreach (Opcion opcion in opciones)
            {
                Console.WriteLine(opciones.IndexOf(opcion) + " .  " + opcion.Message);
            }
        }

        public void seleccionarOpcion()
        {
            int numOpcion = int.Parse(Console.ReadLine());
            Console.Clear();
            opciones[numOpcion].Action.Invoke();
            Console.Clear();
        }
        public void Continuar()
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
        }

        public void SeleccionarCalculo()
        {
            Console.WriteLine("\nSeleccione la opción que desee calcular: ");
            Console.WriteLine("1) Área");
            Console.WriteLine("2) Perímetro");
            Console.WriteLine("3) Ambos\n");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (opcion == 1)
            {
                Console.WriteLine("El área es: " + figura.CalcularArea());
            }
            else if (opcion == 2)
            {
                Console.WriteLine("El perímetro es: " + figura.CalcularPerimetro());
            }
            else if (opcion == 3)
            {
                Console.WriteLine("El área es: " + figura.CalcularArea());
                Console.WriteLine("El perímetro es: " + figura.CalcularPerimetro());
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                SeleccionarCalculo();
            }

            Console.WriteLine();
            Continuar();
        }

        ////

        public void Circulo()
        {
            Console.Write("Ingrese el radio del círculo: ");
            float radio = float.Parse(Console.ReadLine());

            figura = new Circulo("Círculo", radio);
            SeleccionarCalculo();
        }

        public void Rectangulo()
        {
            Console.Write("Ingrese la base del rectángulo: ");
            float largo = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            float ancho = float.Parse(Console.ReadLine());

            figura = new Rectangulo("Rectángulo", largo, ancho); 
            SeleccionarCalculo();
        }

        public void Triangulo()
        {
            Console.WriteLine("Ingrese los valores para el triángulo:");

            Console.Write("Lado A (que será la base): ");
            float ladoA = float.Parse(Console.ReadLine());

            Console.Write("Lado B: ");
            float ladoB = float.Parse(Console.ReadLine());

            Console.Write("Lado C: ");
            float ladoC = float.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            float altura = float.Parse(Console.ReadLine());

            figura = new Triangulo("Triángulo", ladoA, ladoB, ladoC, altura);
            SeleccionarCalculo();
        }
        public void Pentagono()
        {
            Console.Write("Ingrese el lado del pentágono: ");
            float lado = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la apotema del pentágono: ");
            float apotema = float.Parse(Console.ReadLine());

            figura = new Pentagono("Pentágono", lado, apotema); 
            SeleccionarCalculo();
        }

        public void Hexagono()
        {
            Console.Write("Ingrese el lado del hexágono: ");
            float lado = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la apotema del hexágono: ");
            float apotema = float.Parse(Console.ReadLine());

            figura = new Hexagono("Hexágono", lado, apotema);
            SeleccionarCalculo();
        }

        public void Salir()
        {
            Console.WriteLine("Cerrando el programa...");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
