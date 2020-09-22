using System;
using System.Collections.Generic;
using System.Text;

namespace TP2.Generador_Random
{
    public interface IGenerador
    {
        string Gen_Nombre();
        int Gen_DNI();
        int Gen_Legajo();
        double Gen_Promedio();
    }
}
