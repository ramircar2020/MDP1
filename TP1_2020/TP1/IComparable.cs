using System;
namespace TP1
{
    interface IComparable
    {
        bool sosIgual(IComparable valor);
        bool sosMenor(IComparable valor);
        bool sosMayor(IComparable valor);
    }
}