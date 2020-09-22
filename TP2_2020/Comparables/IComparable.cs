using System;
using System.Collections.Generic;
using System.Text;

namespace TP2.Comparables
{
    public interface IComparable
    {
        bool sosIgual(IComparable comparable);
        bool sosMenor(IComparable comparable);
        bool sosMayor(IComparable comparable);
    }
}
