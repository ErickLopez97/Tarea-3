using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo, nombre;
            int nota1, nota2, nota3, suma, promedio;
            
            Console.WriteLine("Introduzca el codigo el estudiante");
            codigo = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre el estudiante");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca la nota de Fisica del estudiante");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la nota de Quimica del estudiante");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la nota de Programacion del estudiante");
            nota3 = int.Parse(Console.ReadLine());


            Console.WriteLine(); 
            Console.WriteLine("Codigo de estudiante: " + codigo);
            Console.WriteLine("Nombre de estudiante: " + nombre);
            Console.WriteLine("Nota de Fisica: " + nota1);
            Console.WriteLine("Nota de Quimica: " + nota2);
            Console.WriteLine("Nota de Programacion: " + nota3);
            suma = nota1 + nota2 + nota3;
            Console.WriteLine("La suma de las nota es: " +suma);
            promedio = suma/3;
            Console.WriteLine("El promedio de las tres notas es: "+promedio);

            Console.ReadKey();
        }
    }
}
