using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //opciones
            Console.WriteLine("Elige una opcion\n" + 
                "\n1.- Suma" +
                "\n2.- Resta" +
                "\n3.- Multiplicacion" +
                "\n4.- Division" +
                "\n5.- Salir" 
                );

            String s1 = null;
            s1 = Console.ReadLine();

            switch(s1)
            {
                case "1":
                    Console.WriteLine("Seleccionaste la opcion suma");
                    break;
                case "2":
                    Console.WriteLine("Seleccionaste la opcion resta");
                    break;
                case "3":
                    Console.WriteLine("Seleccionaste la opcion multiplicacion");
                    break;
                case "4":
                    Console.WriteLine("Seleccionaste la opcion division");
                    break;
                case "5":
                    Console.WriteLine("Seleccionaste la opcion salir");
                    break;
                default:
                    Console.WriteLine("la opcion es incorrecta, intente de nuevo :(");
                    break;
            }
            Console.ReadKey();
        }
    }
}
