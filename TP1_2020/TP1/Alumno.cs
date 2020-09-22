using System;

namespace TP1
{
    class Alumno: Persona
    {
        private int legajo;
        private int promedio;
        
        public Alumno(string n, int d, int l, int p): base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        override public bool sosIgual(IComparable comparable)
        {
            if (((Alumno)(comparable)).getPromedio() == this.promedio)
               return true;
            else
            	return false;
        }

        override public bool sosMenor(IComparable comparable)
        {
            if (((Alumno)(comparable)).getLegajo() > this.legajo)
               return true;
            else
                return false;  
        }

        override public bool sosMayor(IComparable comparable)
        {
            if (((Alumno)(comparable)).getLegajo() < this.legajo)
                return true;
            else
                return false;
         }
    }
}