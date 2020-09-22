using System;
using System.Collections.Generic;

namespace TP1
{
    class ColeccionMultiple: IColeccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int cuantos()
        {
        	return this.cola.cuantos(); 
        }
        // disable once MethodOverloadWithOptionalParameter
        public List<int> cuantos(int input = 0)
        {
        	return new List<int>() 
        	{	this.cola.cuantos(),this.pila.cuantos()};			
        }
        
        public IComparable minimo()
        {
            IComparable minPila = this.pila.minimo();
            IComparable minCola = this.cola.minimo();
            if (minPila.sosMenor(minCola))
                return minPila;
            else
                return minCola;
        }

        public IComparable maximo()
        {
            IComparable maxPila = this.pila.maximo();
            IComparable maxCola = this.cola.maximo();
            if (maxPila.sosMayor(maxCola))
                return maxPila;
            else
                return maxCola;
        }

		public void agregar(IComparable valor)
		{
			throw new NotImplementedException();
		}

        public bool contiene(IComparable comparable)
        {
            bool tienepila = this.pila.contiene(comparable);
            bool tienecola = this.cola.contiene(comparable);
            if (tienepila || tienecola)
                return true;
            else
                return false;
         }
        
        
    }
}