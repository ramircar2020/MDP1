using System;
using System.Collections.Generic;

namespace TP1
{
    class Cola:IColeccionable
    {
        private List<IComparable> cola;

        public Cola()
        {
            this.cola = new List<IComparable>();
        }

        public int cuantos()
        {
            return this.cola.Count;
        }

        public IComparable minimo()
        {
            IComparable minimo = this.cola[0];

            for(int i=0;i<this.cuantos();i++)
            {
                if( this.cola[i].sosMenor(minimo))
                    minimo = this.cola[i];
            }
            return minimo;
        }

        public IComparable maximo()
        {
            IComparable maximo = this.cola[0];
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.cola[i].sosMayor(maximo))
                    maximo = this.cola[i];
            }
            return maximo;
        }

        public void agregar(IComparable coleccion)
        {
            this.cola.Add(coleccion);
        }

        public bool contiene(IComparable coleccion)
        {
            foreach (IComparable a in this.cola)
            {
                if (a.sosIgual(coleccion))
                    return true;
            }
            return false;
        }
    }
}