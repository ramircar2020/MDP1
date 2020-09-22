using System;
using System.Collections.Generic;
using System.Text;
using TP2.Coleccionables;
using TP2.Comparables;
using TP2.Generador_Random;
using TP2.Patron_Iterator;
namespace TP2.Patron_Strategy
{
    public class StratComparacion_Nombre : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre).Equals(0) ? true : false;
        }
        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) > 0 ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) < 0 ? true : false;
        }

    }

    public class StratComparacion_DNI : IStrategy<Persona>
    {

        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return comparable.DNI.Equals(invocador.DNI) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return comparable.DNI > invocador.DNI ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return comparable.DNI < invocador.DNI ? true : false;
        }
    }

    public class StratComparacion_Legajo : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo.Equals(((Alumno)invocador).Legajo) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo > ((Alumno)invocador).Legajo ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo < ((Alumno)invocador).Legajo ? true : false;
        }
    }

    public class StratComparacion_Promedio : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio.Equals(((Alumno)invocador).Promedio) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio > ((Alumno)invocador).Promedio ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio < ((Alumno)invocador).Promedio ? true : false;
        }
    }
}