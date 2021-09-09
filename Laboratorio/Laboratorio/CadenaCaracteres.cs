using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class CadenaCaracteres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Cadena de Caracteres----");
            Console.WriteLine("Ejercicios:");
            Console.WriteLine("A");
            string Palabra_1 = "Hola";
            string Palabra_2 = "Mundo";
            string Frase = "";
            Console.WriteLine(Palabra_1);//Hola
            Console.WriteLine(Palabra_2);//Mundo
            Console.WriteLine("");

            Console.WriteLine("B");
            Console.WriteLine(Palabra_1 + Palabra_2);//HolaMundo
            Console.WriteLine(Palabra_2 + Palabra_1);//MundoHola
            

            Console.ReadKey();

        }
    }
}
