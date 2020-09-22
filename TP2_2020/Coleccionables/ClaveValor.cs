using System;
using System.Collections.Generic;
using System.Text;
using TP2.Comparables;

namespace TP2.Coleccionables
{
    class ClaveValor
    {
        public Numero clave;
        public Persona valor;
        public ClaveValor(Numero in_clave, Persona in_valor)
        {
            this.clave = in_clave;
            this.valor = in_valor;
        }
    }
}
