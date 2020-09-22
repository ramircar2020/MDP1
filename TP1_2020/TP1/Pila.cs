using System;
using System.Collections.Generic;

namespace TP1
{
    class Pila:IColeccionable
    {
        public List<IComparable> pila;

        public Pila()
        {
            this.pila = new List<IComparable>();
        }

        public int cuantos()
        {
            return this.pila.Count;
        }

        public IComparable minimo()
        {
            IComparable minimo = this.pila[0];
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.pila[i].sosMenor(minimo))
                    minimo = this.pila[i];
             }
            return minimo;
        }

        public IComparable maximo()
        {
            IComparable maximo = this.pila[0];
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.pila[i].sosMayor(maximo))
                    maximo = this.pila[i];
            }
            return maximo;
        }

        public void agregar(IComparable coleccion)
        {
            this.pila.Add(coleccion);
        }

        public bool contiene(IComparable coleccion)
        {
            foreach (IComparable a in pila)
            {
                if (a.sosIgual(coleccion))
                    return true;
            }
            return false; 
        }
    }
}