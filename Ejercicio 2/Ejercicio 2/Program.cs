using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.Write("Indique un numero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
                Console.Write("El numero"+num1+ " es Par");
            else
                Console.Write("El numero " +num1+ " es Impar");

            Console.ReadKey();
        }
    }
}
