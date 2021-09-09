using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class AsignacionCompacta
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Asignacion Compacta----");
            Console.WriteLine("Ejercicios:");
            Console.WriteLine("A");
            int X = 10;
            int Y = 20;
            Console.WriteLine(X);//10
            Console.WriteLine(Y);//20
            Console.WriteLine("");

            Console.WriteLine("B");
            X += 5;
            Y -= 15;
            Console.WriteLine(X);//15
            Console.WriteLine(Y);//5
            Console.WriteLine("");

            Console.WriteLine("C");
            X++;
            Y--;
            Console.WriteLine(X);//16
            Console.WriteLine(Y);//6
            Console.WriteLine("");

            Console.WriteLine("D");
            X *= 4;
            Y *= -3;
            Console.WriteLine(X);//64
            Console.WriteLine(Y);//-18
            Console.WriteLine("");

            Console.WriteLine("C");
            X /= 2;
            Y /= -6;
            Console.WriteLine(X);//32
            Console.WriteLine(Y);//3
            Console.WriteLine("");

            Console.ReadKey();

        }
    }
}
