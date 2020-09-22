﻿using System;
using System.Collections.Generic;
using System.Text;
using TP2.Comparables;
using TP2.Generador_Random;
using TP2.Patron_Iterator;
using TP2.Patron_Strategy;

namespace TP2.Coleccionables
{
    class Pila : IColeccionable<Persona>, CreateIterator
    { 
        List<Persona> pila;

        #region Propio:
        public Pila()
        {
            this.pila = new List<Persona>();
        }
        public void push(Persona elemento)
        {
            this.pila.Add(elemento);
        }

        //Extraer un elemento de cola.
        public Persona pop()
        {
            Persona firstPila = this.pila[this.pila.Count - 1];
            this.pila.RemoveAt(this.pila.Count - 1);
            return firstPila;
        }

        public Persona popX(int puntero)
        {
            Persona firstPila = this.pila[this.pila.Count - puntero];
            return firstPila;
        }

        public bool isEmpty()
        {
            return this.pila.Count.Equals(0) ? true : false;
        }

        public Persona top()
        {
            return this.pila[this.pila.Count - 1];
        }

        public int size()
        {
            return this.pila.Count;
        }

        //Retorna una nueva cola con los elementos en posición invertida(el primero en último lugar).
        public Pila reverse()
        {
            Pila reverse = new Pila();
            for (int i = 1; i <= this.pila.Count; i++)
            {
                reverse.push(this.pila[-i]);
            }
            return reverse;
        }

        //Agrega a la cola receptora todos los elementos de otra cola(respetando el orden original de salida).
        public void pushAll(Pila newCola)
        {
            for (int i = 0; i < newCola.size(); i++)
            {
                this.pila.Add(newCola.pop());
            }
        }
        #endregion

        #region Heredado:
        //Devuelve la cantidad de elementos comparables que tiene el coleccionable
        public int cuantos()
        {
            return this.pila.Count;
        }

        //Devuelve menor valor de la colección
        public Persona minimo()
        {
            Persona minValue = this.pila[0];
            Persona valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.pila[i];
                minValue = valor.sosMenor(minValue) ? valor : minValue;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public Persona maximo()
        {
            Persona maxValue = this.pila[0];
            Persona valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.pila[i];
                maxValue = valor.sosMayor(maxValue) ? valor : maxValue;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Persona comparable)
        {
            this.pila.Add(comparable);
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Persona comparable)
        {
            Persona valor;
            bool encontrado = false;
            for (int i = 0; i < cuantos() && encontrado.Equals(false); i++)
            {
                valor = this.pila[i];
                encontrado = comparable.DNI == valor.DNI ? true : false;
            }
            return encontrado;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Pila(this);
        }
        #endregion
    }
}
