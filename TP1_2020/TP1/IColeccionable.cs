using System;

namespace TP1
{
    interface IColeccionable
    {
        int cuantos();
        IComparable minimo();
        IComparable maximo();
        void agregar(IComparable valor);
        bool contiene (IComparable valor);
    }
}