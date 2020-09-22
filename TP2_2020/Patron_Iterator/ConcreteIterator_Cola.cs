using System;
using TP2.Coleccionables;
using TP2.Comparables;

namespace TP2.Patron_Iterator
{
    public class ConcreteIterator_Cola:IIterator
    {
        public Cola lista;
        public int actual = 0;

        public ConcreteIterator_Cola(Cola in_lista)
        {
            this.lista = in_lista;
        }

        public bool EsFin()
        {
            return actual < this.lista.cuantos() ? false : true;
        }

        public void Reset()
        {
            this.actual = 0;
        }

        public object Siguiente()
        {
            var anterior = this.lista.popX(actual);
            actual++;
            return anterior;

        }
    }
}
