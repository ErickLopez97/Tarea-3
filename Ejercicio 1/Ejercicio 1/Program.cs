using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Indique un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Indique un numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.Write(+num1+" y "+num2+ " son iguales.");
            else
                Console.Write("No son iguales");

            Console.ReadKey();
        }
    }
}
