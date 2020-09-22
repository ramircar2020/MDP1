using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
	public class Main	
	{
        public static void RunTP1()
        {
            Cola cola = new Cola();
            Pila pila = new Pila();
            
            llenarAlumnos(cola);
            llenarAlumnos(pila);
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            informar(multiple); //informa cola y pila
            
            for(int i=0;i<pila.pila.Count;i++)
            {
            	Console.WriteLine("\t" + ((Alumno)(pila.pila[i])).getLegajo());
            }
            Console.ReadKey();
        }

        static void llenar(IColeccionable coleccion)
        {
            Random rnd = new Random();
            for(int i=0;i<20;i++)
            {
                IComparable llenado = new Numero(rnd.Next(1, 101));
                coleccion.agregar(llenado);
            }
        }
        static void informar (ColeccionMultiple coleccion)
        {
            Console.Clear();
            Console.WriteLine("\n\tLa Cant. de elementos en la COLA es: " + coleccion.cuantos(0)[0]);
            Console.WriteLine("\tLa Cant. de elementos en la PILA es: " + coleccion.cuantos(0)[1]);
            Console.WriteLine("\tLa persona con DNI más bajo es: "+ ((Persona)coleccion.minimo()).getNombre());
            Console.WriteLine("\tY su Legajo es: "+ ((Alumno)coleccion.minimo()).getLegajo() + "\n");      

//	TP1 Ejercicio 6 -->DESACTIVÉ ESTA PARTE, YA QUE EN EJECUCION EXPLOTA CON:
//	/// System.InvalidCastException: No se puede convertir un objeto de tipo 'TP1.Persona' al tipo 'TP1.Alumno'/// 

            Console.WriteLine("\nPor favor, ingresar un DNI para ver si está en la coleccion: ");
            int inKbdDNI = Convert.ToInt32(Console.ReadLine());
            Persona newPersona = new Persona("persona", inKbdDNI);
            if (coleccion.contiene(newPersona))
            {	Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("El elemento leido SI está en la coleccion");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("El elemento leído NO está en la colección");
				Console.ForegroundColor = ConsoleColor.White;
        	}

        }
        static void llenarPersonas(IColeccionable coleccion)
        {
            Random rnd = new Random();
            for(int i=0;i<20;i++)
            {
                string nombre = Path.GetRandomFileName();
                int dni = rnd.Next(20000000, 44000000);
                IComparable persona = new Persona(nombre, dni);
                coleccion.agregar(persona);
            }
        }

        static void llenarAlumnos(IColeccionable coleccion)
        {
            Random rnd = new Random();
            for(int i=0; i<20;i++)
            {
                string nombre = Path.GetRandomFileName();
                int dni = rnd.Next(20000000, 44000000);
                int legajo = rnd.Next(1, 999999);
                int promedio = rnd.Next(1,10);
                IComparable alumno = new Alumno(nombre, dni, legajo, promedio);
                coleccion.agregar(alumno);
            }
        }
    }
}