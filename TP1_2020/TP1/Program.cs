/*Carlos RAMIREZ MIERS Comisión 2 - 2°C 2020*/

using System;

namespace TP1
{
class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (salir.Equals(false))
            {	Console.ForegroundColor = ConsoleColor.Green;
            	Console.WriteLine("\t Elija una opcion: " + "\n\t *****************\n");
            	Console.ForegroundColor = ConsoleColor.White;
            	Console.WriteLine("\t1) Correr programa");
                Console.WriteLine("\t0) Salir" + "\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\tIngrese su opcion: ");
                Console.ForegroundColor = ConsoleColor.White;
                int eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {	case 1:
                		TP1.Main.RunTP1();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\tElija una opcion: ");
                        Console.ReadKey();
                        break;
                }
            }
    	}
	}
}
