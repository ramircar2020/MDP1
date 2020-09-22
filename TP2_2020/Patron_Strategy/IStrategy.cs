using System;
using System.Collections.Generic;
using System.Text;
namespace TP2.Patron_Strategy
{
    public interface IStrategy<T>
    {
        bool sosIgual(T invocador,T comparable);
        bool sosMenor(T invocador, T comparable);
        bool sosMayor(T invocador, T comparable);
    }
}
