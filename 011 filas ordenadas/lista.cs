using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_filas_ordenadas
{
    class Nodo
    {
        public int dato;
        public Nodo siguiente;
    }
    class Lista 
    {
        Nodo lista;
        public Lista()
        {
            lista = null;
        }

        public void Agregar(int n)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = n;


            Nodo aux1 = lista;
            Nodo aux2=null;
            while (aux1 != null && aux1.dato < n)
            {
                aux2 = aux1;
                aux1 = aux1.siguiente;
            }
            if (lista == aux1)
            {
                lista = nuevoNodo;
            }
            else
            {
                aux2.siguiente = nuevoNodo;
            }

            nuevoNodo.siguiente = aux1;
        }
        public void Mostrar()
        {
            Nodo aux = lista;
            while (aux != null)
            {
                Console.Write("{0} ", aux.dato);
                aux = aux.siguiente;
            }
            Console.WriteLine();
        }

    }
}
