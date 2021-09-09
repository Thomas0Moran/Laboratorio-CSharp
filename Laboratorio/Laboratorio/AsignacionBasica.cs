using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class AsignacionBasica
    {

        static void Main(string[] args)
        {
            Console.WriteLine("----Asignacion Basica----");
            Console.WriteLine("Ejercicios:");
            Console.WriteLine("A");
            int A = 10;
            int B = 20;
            Console.WriteLine(A);//10
            Console.WriteLine(B);//20
            Console.WriteLine("");

            Console.WriteLine("B");
            A = A + 5;
            B = B + 10;
            Console.WriteLine(A);//15
            Console.WriteLine(B);//30
            Console.WriteLine("");

            Console.WriteLine("C");
            A = A -10;
            B = B -15;
            Console.WriteLine(A);//5
            Console.WriteLine(B);//15
            Console.WriteLine("");

            Console.WriteLine("D");
            A = A * 2;
            B = B * 2;
            Console.WriteLine(A);//10
            Console.WriteLine(B);//30
            Console.WriteLine("");

            Console.ReadKey();

        }
    }
}
