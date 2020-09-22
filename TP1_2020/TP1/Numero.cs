using System;
namespace TP1
{
    class Numero:IComparable
    {
        private int valor;

        public Numero (int v)
        {
            this.valor = v;
        }

        public int getValor()
        {
            return this.valor;
        }

        public bool sosIgual(IComparable v)
        {
            
            if(this.getValor() == ((Numero)(v)).getValor())
            	return true;
            else
                return false;
        }

        public bool sosMayor(IComparable v)
        {
            if(this.getValor() > ((Numero)(v)).getValor())
                return true;
            else
                return false;
        }

        public bool sosMenor(IComparable v)
        {
            if(this.getValor() < ((Numero)(v)).getValor())
                return true;
            else
                return false;
        }

    }
}