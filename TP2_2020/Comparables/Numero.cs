using System;
using System.Collections.Generic;
using System.Text;

namespace TP2.Comparables
{ 
    class Numero : IComparable
    {
        private int _valor;

        public int Valor 
        {
            get { return this._valor; }
            set { this._valor = value; }
        }

        public Numero(int v)
        {
            this._valor = v;
        }

        public bool sosIgual(IComparable comparable)
        {
            return ((Numero)comparable).Valor == this._valor ? true : false;
        }

        public bool sosMenor(IComparable comparable)
        {
            return ((Numero)comparable).Valor > this._valor ? true : false;
        }

        public bool sosMayor(IComparable comparable)
        {
            return ((Numero)comparable).Valor < this._valor ? true : false;
        }
    }
}
