using System;
using System.Collections.Generic;
using System.Text;
using TP2.Coleccionables;
using TP2.Comparables;
using TP2.Generador_Random;
using TP2.Patron_Iterator;

namespace TP2.Patron_Strategy
{
    public class Main
    {
        public static void Run(int TipoEstrategia)
        {
            Generar generar = new Generar();
            Cola personas = new Cola();
            Pila alumnos = new Pila();
            //Hardcodeo Creacion Personas
            Persona p1 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p2 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p3 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p4 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p5 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p6 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p7 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p8 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p9 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            //Fin creacion de Personas
            personas.agregar(p1); personas.agregar(p2); personas.agregar(p3); personas.agregar(p4); personas.agregar(p5); personas.agregar(p6);
            personas.agregar(p7); personas.agregar(p8); personas.agregar(p9);

            //Crea Alumnos
            Alumno a1 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a2 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a3 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a4 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a5 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a6 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a7 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a8 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a9 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            // Fin crea Alumnos

            alumnos.agregar(a1); alumnos.agregar(a2); alumnos.agregar(a3); alumnos.agregar(a4); alumnos.agregar(a5); alumnos.agregar(a6); alumnos.agregar(a7);
            alumnos.agregar(a8); alumnos.agregar(a9);

            switch (TipoEstrategia)
            {
                case 1:
                    break;
                case 2:
                    cambioEstrategia(personas, new StratComparacion_DNI());
                    cambioEstrategia(alumnos, new StratComparacion_DNI());
                    break;
                case 3:
                    cambioEstrategia(personas, new StratComparacion_Legajo());
                    cambioEstrategia(alumnos, new StratComparacion_Legajo());
                    break;
                case 4:
                    cambioEstrategia(personas, new StratComparacion_Promedio());
                    cambioEstrategia(alumnos, new StratComparacion_Promedio());
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tComparamos a1 con a2:");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\tsosIgual: " + a1.sosIgual(a2) + "\n"+
                              "\tsosMenor: " + a1.sosMenor(a2) + "\n"+
							  "\tsosMayor: " + a1.sosMayor(a2));
            Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\tComparamos a3 con a4:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tsosIgual: " + a3.sosIgual(a4) + "\n"+
                              "\tsosMenor: " + a3.sosMenor(a4) + "\n"+
                              "\tsosMayor: " + a3.sosMayor(a4));
            Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\tComparamos a5 con a6:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tsosIgual: " + a5.sosIgual(a6) + "\n" +
                              "\tsosMenor: " + a5.sosMenor(a6) + "\n" +
                              "\tsosMayor: " + a5.sosMayor(a6));
            if (!TipoEstrategia.Equals(3) && !TipoEstrategia.Equals(4))
            {	Console.ForegroundColor = ConsoleColor.Green;
            	Console.WriteLine("\tComparamos p1 con p2:");
            	Console.ForegroundColor = ConsoleColor.White;                  
            	Console.WriteLine("\tsosIgual: " + p1.sosIgual(p2) + "\n" +
                                  "\tsosMenor: " + p1.sosMenor(p2) + "\n" +
                                  "\tsosMayor: " + p1.sosMayor(p2));
				Console.ForegroundColor = ConsoleColor.Green;            	
				Console.WriteLine("\tComparamos p3 con p4:");
            	Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\tsosIgual: " + p3.sosIgual(p4) + "\n" +
                                  "\tsosMenor: " + p3.sosMenor(p4) + "\n" +
                                  "\tsosMayor: " + p3.sosMayor(p4));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tComparamos p5 con p6:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\tsosIgual: " + p5.sosIgual(p6) + "\n" +
                                  "\tsosMenor: " + p5.sosMenor(p6) + "\n" +
                                  "\tsosMayor: " + p5.sosMayor(p6));
            }
        }
        //******************************
        //Ej9
        public static void cambioEstrategia(IColeccionable<Persona> personas, IStrategy<Persona> estrategia)
        {	IIterator iter = personas.CreateIterator();
            while(!iter.EsFin())
            {	Persona unaPersona = (Persona)iter.Siguiente();
                unaPersona.Estrategia = estrategia;
            }
        }
        //******************************
    }
}
