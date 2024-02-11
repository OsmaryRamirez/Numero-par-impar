using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros__impar_y_par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Determinar si un número es par o impar

            Console.WriteLine("Ingrese un número para determinar si es par o impar:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
    }
}
