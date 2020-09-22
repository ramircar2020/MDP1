using System;
using System.Collections.Generic;
using System.Text;
using TP2.Coleccionables;
using TP2.Comparables;
using TP2.Generador_Random;
using TP2.Patron_Strategy;
using TP2.Impresiones;

namespace TP2.Patron_Iterator
{
    class Main
    {
        public static void Run()
        {
            Cola unaCola = new Cola();
            Impresiones.Main.llenarAlumnos(unaCola);
            imprimirElementos(unaCola);
        }

        public static void imprimirElementos(IColeccionable<Persona> coleccion)
        {
            IIterator iter = coleccion.CreateIterator();
            while (!iter.EsFin())
            {
                Alumno elemento = (Alumno)iter.Siguiente();
                Console.WriteLine("\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}",
                     elemento.Nombre, elemento.DNI, elemento.Legajo, elemento.Promedio);
            }
        }
        public static void imprimirElementosDiccionario(IColeccionable<ClaveValor> coleccion)
        {
            IIterator iter = coleccion.CreateIterator();
            while (!iter.EsFin())
            {
                Alumno elemento = (Alumno)iter.Siguiente();
                Console.WriteLine("\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}",
                     elemento.Nombre, elemento.DNI, elemento.Legajo, elemento.Promedio);
            }
        }
    }
}
