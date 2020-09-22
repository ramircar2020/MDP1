using System;
using System.Collections.Generic;
using System.Text;
using TP2.Coleccionables;
using TP2.Comparables;
using TP2.Generador_Random;
using TP2.Patron_Iterator;
using TP2.Patron_Strategy;

namespace TP2.Coleccionables
{
    public interface IColeccionable<T> :CreateIterator
    {
        int cuantos();
        T minimo();
        T maximo();
        void agregar(T comparable);
        bool contiene(T comparable);
    }
}
