using System;
namespace TP2.Patron_Iterator
{
    public interface IIterator
    {
        object Siguiente();
		bool EsFin();
		void Reset();
    }
}
