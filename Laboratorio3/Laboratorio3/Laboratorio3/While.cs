using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class While
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----WHILE-----");
            Console.WriteLine("Ejercicio1:");

            int n = 1;
            while(n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio2:");
            int x = 1;
            while(x <= 10)
            {
                Console.WriteLine(x);
                x += 2;
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio3:");
            int q = 10;
            while(q >= 1)
            {
                Console.WriteLine(q);
                q -=1;
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio4:");
            int w = 1;
            while(w <= 10)
            {
                if ((w != 2) && (w != 5) && (w !=9))
                {
                    Console.WriteLine(w);
                }
                w++;
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio5:");
            int e = 1;
            while(e <=30)
            {
                if((e <10) || (e >20))
                {
                    Console.WriteLine(e);
                }
                e++;
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio6:");
            int a = 1;
            int suma = 0;
            while (a<=10)
            {
                suma = suma + a;
                a++;
            }
            Console.WriteLine("La suma del 1 al 10 es=" + suma);
            Console.WriteLine("");

            Console.WriteLine("Ejercicio7:");
            Console.WriteLine("");
            int s = 1;
            int sumaa = 0;
            while(s <=25)
            {
                if(s % 2 == 0)
                {
                    sumaa = sumaa + s;
                }
                s++;
                Console.WriteLine("la suma de pares del 1 al 25 da=" + sumaa);
            }
            Console.WriteLine("");

            Console.WriteLine("-----FOR-----");
            Console.WriteLine("Ejercicio1:");

            for (int m = 1; m <= 10; m++)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio2:");
            for (int l = 1; l<=10; l+=2)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio3:");
            for (int j = 10; j > 0; j -= 1)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio4:");
            for (int i =1; i <=4; i++)
            {
                Console.WriteLine("@");
            }








            Console.ReadKey();
            
        }
    }
}
