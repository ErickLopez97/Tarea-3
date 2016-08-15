using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Introduzca el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                {
                Console.WriteLine("El numero " + num1 + " es el mayor");
                }
                 else
                 {
                    if(num2 > num1 && num2 > num3)
                    {
                    Console.WriteLine("El numero " + num2 + " es el mayor");
                    }      
                    else
                    {
                    Console.WriteLine("El numero " +num3+ " es el mayor");
                    }
                }
            Console.ReadLine();
        }
    }
}
