using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Vectores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Utilización de Vectores-----");
            Console.WriteLine("Ejercicio 1:");

            int[] vec = { 10, 20, 5, 15, 30, 20 };
            int n, total = 0, maximo = vec[0], cont = 0;
            for (n=0; n < vec.Length; n++)
            {
                if(n % 2 ==1)
                {
                    Console.WriteLine("Pocision impar es " + n + " " + "valor:" + vec[n]);
                }
                total = total + vec[n];
                if(vec[n] > maximo)
                {
                    maximo = vec[n];
                }
                if(vec [n] ==20)
                {
                    cont++;
                }
            }
            Console.WriteLine("El mayor es: " + maximo);
            Console.WriteLine("El total es: " + total);
            Console.WriteLine("El 20 aparecio:" + cont + "veces");

            Console.ReadKey();

        }
    }
}
