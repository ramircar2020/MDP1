using System;
//using System.Collections.Generic;
//using System.Text;
using TP2.Coleccionables;
using TP2.Comparables;
using TP2.Generador_Random;
//using TP2.Patron_Iterator;
using TP2.Patron_Strategy;

namespace TP2.Impresiones
{
    class Main
    {
        public static void Run()
        {	Cola C_personas = new Cola();
            Cola C_alumnos = new Cola();
            Pila P_personas = new Pila();
            Pila P_alumnos = new Pila();

            llenarAlumnos(C_alumnos);
            llenarAlumnos(P_alumnos);
            llenarPersonas(P_personas);
            llenarPersonas(C_personas);

            ColeccionMultiple CM_personas = new ColeccionMultiple(P_personas, C_personas);
            ColeccionMultiple CM_alumnos = new ColeccionMultiple(P_alumnos, C_alumnos);

            informarPersonas(CM_personas);
            informarPersonas(CM_alumnos);
        }

        public static void Run2()
        {
            //Ej 8
            Pila newPila = new Pila();
            Cola newCola = new Cola();
            Conjunto newConjunto = new Conjunto();
            Diccionario newDiccionario = new Diccionario();
            llenarAlumnos(newPila);
            llenarAlumnos(newCola);
            llenarAlumnos((IColeccionable<Persona>)newConjunto);
            llenarAlumnosDiccionario(newDiccionario);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tPila: ");
            Console.ForegroundColor = ConsoleColor.White;
            Patron_Iterator.Main.imprimirElementos(newPila);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tCola: ");
            Console.ForegroundColor = ConsoleColor.White;
            Patron_Iterator.Main.imprimirElementos(newCola);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tConjunto: ");
            Console.ForegroundColor = ConsoleColor.White;
            Patron_Iterator.Main.imprimirElementos((IColeccionable<Persona>)newConjunto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tDiccionario: ");
            Console.ForegroundColor = ConsoleColor.White;
            Patron_Iterator.Main.imprimirElementosDiccionario(newDiccionario);
        }

        public static void Run3()
        {	//Ej10
            Pila newPila = new Pila();
            llenarAlumnos(newPila);
            Patron_Strategy.Main.cambioEstrategia(newPila,new StratComparacion_Nombre());
            informar(newPila);

            Patron_Strategy.Main.cambioEstrategia(newPila, new StratComparacion_DNI());
            informar(newPila);

            Patron_Strategy.Main.cambioEstrategia(newPila, new StratComparacion_Legajo());
            informar(newPila);

            Patron_Strategy.Main.cambioEstrategia(newPila, new StratComparacion_Promedio());
            informar(newPila);
            //
            Console.WriteLine();
            Patron_Iterator.Main.imprimirElementos(newPila);
        }
        public static void informarPersonas(ColeccionMultiple inColeccionable)
        {
            Console.WriteLine("\n\tLa cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos(0)[0] + "\n" +
                              "\tLa cantidad de elementos que existen en la Pila son: " + inColeccionable.cuantos(0)[1] + "\n" +
                              "\tLa Persona con menor numero de DNI entre la Cola y la Pila es: " + inColeccionable.minimo().DNI + "\n" +
                              "\tLa Persona con mayor numero de DNI entre la Cola y la Pila es: " + inColeccionable.maximo().DNI);
            Console.ForegroundColor = ConsoleColor.Green;
        	Console.WriteLine("\n\tPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion:\t");
        	Console.ForegroundColor = ConsoleColor.White;
        	int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario", input);
            if (inColeccionable.contiene(newElemento))
            {	Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tEl elemento ingresado esta en la coleccion\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {	Console.ForegroundColor = ConsoleColor.Red;
            	Console.WriteLine("\tEl elemento ingresado no se encuentra en la coleccion");
            	Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
       
        public static void llenarAlumnos(IColeccionable<Persona> coleccion)
        {	Generar generar = new Generar();
        	for (int i = 0; i < 5; i++)
        	{	
        		Alumno unAlumno = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
        		coleccion.agregar(unAlumno);
        	}
        }
        public static void llenarAlumnosDiccionario(IColeccionable<ClaveValor> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {	Alumno unAlumno = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
                ((Diccionario)coleccion).agregar(unAlumno);
            }
        }        
        public static void llenarPersonas(IColeccionable<Persona> coleccion)
        {
            Generar generar = new Generar();
        	for (int i = 0; i < 20; i++)
            {	 
        		Persona unaPersona = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
        		coleccion.agregar(unaPersona);
             }
        }
        public static void informar(IColeccionable<Persona> coleccion)
        {
            Alumno maximo = (Alumno)coleccion.maximo();
            Alumno minimo = (Alumno)coleccion.minimo();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tElementos de la Coleccion:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tMaximo:\n\t\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}\n" +
                "\tMinimo:\n\t\tAlumno: {4}\tDNI: {5}\tLegajo: {6}\tPromedio: {7}",
                     maximo.Nombre, maximo.DNI, maximo.Legajo, maximo.Promedio,
                     minimo.Nombre, minimo.DNI, minimo.Legajo, minimo.Promedio);
        }
    }
}
