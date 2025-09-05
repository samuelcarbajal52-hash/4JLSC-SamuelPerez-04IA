using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4LSC_SamuelPerez_
{
    abstract class FiguraGeometrica
    {
        public abstract string Descripcion();
        public abstract double Area();
    }
    class Cuadrilatero : FiguraGeometrica
    {
        private double baseCuadrilatero, altura;
        public Cuadrilatero(double baseCuadrilatero, double altura)
        {
            this.baseCuadrilatero = baseCuadrilatero;
            this.altura = altura;
        }
        public override string Descripcion()
        {
            return "Figura geometrica Cuadrilatero";
        }
        public override double Area()
        {
            return baseCuadrilatero * altura;
        }
    }
    class Triangulo : FiguraGeometrica
    {
        private double baseTriangulo;
        private double altura;
        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }
        public override string Descripcion()
        {
            return "Figura geometrica Triangulo";
        }

        public override double Area()
        {
            return (baseTriangulo * altura / 2);
        }
    }
    class Circulo : FiguraGeometrica
    {
        private double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override string Descripcion()
        {
            return "Figura geometrica Circulo";
        }
        public override double Area()
        {
            return (radio * radio) * Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una Figura Geometrica:");
            Console.WriteLine("1. Cuadrilatero");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Circulo");
            Console.Write("Ingrese el numero de la figura que desea: ");
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                FiguraGeometrica figura = null;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese la base del Cuadrilatero:");
                        if (!double.TryParse(Console.ReadLine(), out double baseCuadrilatero))
                        {
                            Console.WriteLine("Error: Entrada inválida para la base.");
                            return;
                        }
                        Console.WriteLine("Ingrese la altura del Cuadrilatero:");
                        if (!double.TryParse(Console.ReadLine(), out double alturaC))
                        {
                            Console.WriteLine("Error: Entrada inválida para la altura.");
                            return;
                        }
                        figura = new Cuadrilatero(baseCuadrilatero, alturaC);
                        break;
                    case 2:
                        Console.WriteLine("Ingresa la base del triángulo:");
                        if (!double.TryParse(Console.ReadLine(), out double baseT))
                        {
                            Console.WriteLine("Error: Entrada inválida para la base.");
                            return;
                        }
                        Console.WriteLine("Ingresa la altura del triángulo:");
                        if (!double.TryParse(Console.ReadLine(), out double alturaT))
                        {
                            Console.WriteLine("Error: Entrada inválida para la altura.");
                            return;
                        }
                        figura = new Triangulo(baseT, alturaT);
                        break;
                    case 3:
                        Console.WriteLine("Ingresa el radio del círculo:");
                        if (!double.TryParse(Console.ReadLine(), out double radio))
                        {
                            Console.WriteLine("Error: Entrada inválida para el radio.");
                            return;
                        }
                        figura = new Circulo(radio);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        return;
                }
                Console.WriteLine(figura.Descripcion());
                Console.WriteLine($"El área es: {figura.Area():F2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número.");
            }
        }
    }
}
