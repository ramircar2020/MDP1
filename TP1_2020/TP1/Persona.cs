using System;

namespace TP1
{
    class Persona:IComparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getDNI()
        {
            return this.dni;
        }

        virtual public bool sosIgual(IComparable comparable)
        {
            if (((Persona)(comparable)).getDNI() == this.dni)
                return true;
            else
                return false;
        }

        virtual public bool sosMenor(IComparable comparable)
        {
            if (((Persona)(comparable)).getDNI() > this.dni)
                return true;
            else
                return false;  
        }

        virtual public bool sosMayor(IComparable comparable)
        {
            if (((Persona)(comparable)).getDNI() < this.dni)
                return true;
            else
                return false;
        }

    }
}