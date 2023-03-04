using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_JCSA_1020022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condicion = false;
            string repetir = "no";
            do
            {
                menu();
                Console.WriteLine("Desea seguir? ingrese si");
                repetir = Console.ReadLine().ToLower();
                if (repetir.Contains("si"))
                {
                    condicion = true;
                }
                else
                {
                    condicion = false;
                }
                Console.Clear();
                Console.ReadKey();
            } while (condicion);
            Console.ReadKey();
        }
        static void menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine(" a) Sumatoria");
            Console.WriteLine(" b) Mostrar tablas de multiplicar");
            Console.WriteLine(" c) Numero Perfecto");
            Console.Write("Ingrese la opcion que desea realizar (ejemplo *a*):");
            char opcion = Console.ReadLine().ToLower()[0];
            switch (opcion)
            {
                case 'a':
                    Sumatoria();
                    break;
                case 'b':
                    TablasMultiplicar();
                    break;
                case 'c':
                    NumeroPerfecto();
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no es válida.");
                    break;
            }
        }

        static void Sumatoria()
        {
            int n;
            do
            {
                Console.Write("Por favor ingrese un número positivo: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            int suma = 0;
            int i = 1;
            do
            {
                suma += i;
                i++;
            } 
            while (i <= n);

            Console.WriteLine($"La suma de los números de 1 a {n} es: {suma}");
        }
        static void TablasMultiplicar()
        {
            int n;
            do
            {
                Console.Write("Por favor ingrese un número para mostrar su tabla de multiplicar: ");
            } 
            while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
        static void NumeroPerfecto()
        {
            int n;
            do
            {
                Console.Write("Por favor ingrese un número mayor a 0 para verificar si es perfecto: ");
            } 
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            int sumaFactores = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sumaFactores += i;
                }
            }

            if (sumaFactores == n)
            {
                Console.WriteLine($"El número {n} es perfecto.");
            }
            else
            {
                Console.WriteLine($"El número {n} no es perfecto.");
            }
        }
    }
}

