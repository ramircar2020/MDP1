using System;
using System.Collections.Generic;
using System.Text;
using TP2.Patron_Strategy;

namespace TP2.Comparables
{	public class Persona: IComparable
    {
        private string _nombre;
        private int _dni;
        private IStrategy<Persona> _estrategia;
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        public int DNI { get { return this._dni; } set { this._dni = value; } }
        public IStrategy<Persona> Estrategia { get { return this._estrategia; } set { this._estrategia = value; } }

        public Persona(string in_nombre, int in_dni)
        {
            Nombre = in_nombre;
            DNI = in_dni;
            Estrategia = new StratComparacion_Nombre();
        }
        public Persona()
        {
            Estrategia = new StratComparacion_Nombre();
        }

        public bool sosIgual(IComparable comparable)
        {
            return Estrategia.sosIgual(this, (Persona)comparable);
        }

        public bool sosMenor(IComparable comparable)
        {
            return Estrategia.sosMenor(this, (Persona)comparable);
        }

        public bool sosMayor(IComparable comparable)
        {
            return Estrategia.sosMayor(this, (Persona)comparable);
        }
    }
}
