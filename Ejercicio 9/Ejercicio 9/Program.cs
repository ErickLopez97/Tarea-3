using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Ingresa La Temperatura");
            temp = int.Parse(Console.ReadLine());
            
            if (temp>=30)
            {
                Console.WriteLine("El clima esta muy caliente");
            }
            else
            {
                if (temp < 29 && temp >= 20)
                {
                    Console.WriteLine("El clima esta caliente");
                }
                else
                {
                    if (temp < 19 && temp >= 10)
                    {
                        Console.WriteLine("El clima esta calido");
                    }
                    else
                    {
                        if (temp < 9 && temp >= 10)
                        {
                            Console.WriteLine("El clima esta frio");
                        }
                        else
                        {
                            Console.Write("El clima esta muy frio");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
