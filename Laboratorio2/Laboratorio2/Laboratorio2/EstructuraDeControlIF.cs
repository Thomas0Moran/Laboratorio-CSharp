using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class EstructuraDeControlIF
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Estructuras de Control IF----");
            Console.WriteLine("Ejercicio A:");
            Console.WriteLine("int nro1 = 10, nro2 =20, nro3 = 30");

            int nro1 = 10, nro2 =20, nro3 = 30;

            if(nro1 > nro2 & nro1 >nro3)//10>20 y 10>30
            {
                Console.WriteLine("El nro1 es el mayor:" + nro1);//10
            }
            if(nro2 > nro1 & nro2 > nro3)//20 > 10 y 20 > 30
            {
                Console.WriteLine("El nro2 es el mayor:" + nro2);//20
            }
            if(nro3 > nro2 & nro3 > nro1)//30
            {
                Console.WriteLine("El nro3 es el mayor:" + nro3);//30
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio B:");
            Console.WriteLine("int a=10, b=-2, c=5");

            int a = 10, b = -2, c = 5;
            if(a > 0 & b > 0)//10 > 0 y -2 > 0
            {
                Console.WriteLine("a * b=" + a * b);//falso
            }
            if(a > 0 & c > 0)//10 > 0 y 5 > 0
            {
                Console.WriteLine("a * c ="+ a * c);// verdadero 10*5=50
            }
            if(b > 0 & c > 0)//-2 > 0 y 5 >0
            {
                Console.WriteLine("b * c=" + b * c);//falso
            }
            Console.WriteLine("");

            Console.WriteLine("Ejercicio C:");
            Console.WriteLine("User=Leonel, Pass=1234");


            string user = "Leonel", pass = "1234";
            if (user.Equals("Leonel") & pass.Equals("1234"))
            {
                Console.WriteLine("Bienvenido Leonel");
            }
            Console.WriteLine("");
            Console.WriteLine("User=Juan, Pass=1234");
            if(!(user.Equals("Juan")) & pass.Equals("1234"))
            {
                Console.WriteLine("Usuario incorrecto");
            }

            Console.WriteLine("");
            Console.WriteLine("User=Leonel, Pass=2587");
            if ((user.Equals("Leonel")) & !(pass.Equals("2587")))
            {
                Console.WriteLine("Contraseña incorrecta");
            }
            Console.WriteLine("");


            Console.WriteLine("Ejercicio D:");
            int n1, n2, opcion;
            Console.WriteLine("Ingrese el primer numero:");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su opcion:");
            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicacion");
            Console.WriteLine("4-Division");
            Console.WriteLine("");
            Console.WriteLine("Opcion: *");
            opcion = Int32.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Suma:" + (n1 + n2));
                    break;

                case 2:
                    Console.WriteLine("Resta:" + (n1 - n2));
                    break;

                case 3:
                    Console.WriteLine("Multiplicación:" + (n1 * n2));
                    break;

                case 4:
                    Console.WriteLine("División:" + (n1 / n2));
                    break;
  
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.WriteLine();





            Console.ReadKey();
           
        }
    }
}
