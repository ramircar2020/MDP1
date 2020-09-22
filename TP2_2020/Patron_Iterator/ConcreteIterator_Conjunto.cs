using System;
using TP2.Coleccionables;
using TP2.Comparables;

namespace TP2.Patron_Iterator
{
    class ConcreteIterator_Conjunto:IIterator
    {
        public Conjunto lista;
        public int actual = 0;

        public ConcreteIterator_Conjunto(Conjunto in_lista)
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
            var anterior = this.lista.Almacenamiento[actual];
            actual++;
            return anterior;
        }
    }
}
