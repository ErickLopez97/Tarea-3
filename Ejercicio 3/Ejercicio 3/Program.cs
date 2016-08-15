using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingresa un numero");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("El numero " + n + " es nulo");
            }
            else
            {
                if (n > 0)
                {
                    Console.WriteLine("El numero " + n + " es un numero positivo");
                }
                else
                {
                    Console.WriteLine("El numero " + n + " es un numero negativo");
                }
            }
            Console.ReadLine();
        }
    }
}
