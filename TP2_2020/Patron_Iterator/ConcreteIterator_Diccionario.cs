using System;
using TP2.Coleccionables;
using TP2.Comparables;

namespace TP2.Patron_Iterator
{
    class ConcreteIterator_Diccionario: IIterator
    {
        public Diccionario lista;
        public int actual = 0;

        public ConcreteIterator_Diccionario(Diccionario in_lista)
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
            var anterior = this.lista.Lista_ClaveValor[actual].valor;
            actual++;
            return anterior;
        }
    }
}
