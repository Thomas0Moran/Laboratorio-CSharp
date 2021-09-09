using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class OperadoresAritmeticos
    {

        static void Main(string[] args)
        {
            Console.WriteLine("----Operadores Aritmeticos----");
            Console.WriteLine("Ejercicios:");
            Console.WriteLine("A");
            int W = 10;
            int S = 20;
            Console.WriteLine(W);//10
            Console.WriteLine(S);//20
            Console.WriteLine("");

            Console.WriteLine("B");
            W = W + S;
            S = S + W;
            Console.WriteLine(W);//30
            Console.WriteLine(S);//30
            Console.WriteLine("");

            Console.WriteLine("C");
            W = W - S + 2;
            S = S - W + 4;
            Console.WriteLine(W);//2
            Console.WriteLine(S);//4
            Console.WriteLine("");

            Console.WriteLine("D");
            W = W * S + W;
            S = S * W + 2;
            Console.WriteLine(W);//8
            Console.WriteLine(S);//10
            Console.WriteLine("");

            /*Console.WriteLine("C");
            W = W / S;
            S = S / W;
            Console.WriteLine(W);//
            Console.WriteLine(S);//
            Console.WriteLine("");
            VA A DAR ERROR
            */

            Console.ReadKey();
        }
    }
}
