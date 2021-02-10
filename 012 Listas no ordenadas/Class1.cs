using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Listas_no_ordenadas
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


            Nodo aux1 = null;

            if (lista == null)
            {
                lista = nuevoNodo;
                nuevoNodo.siguiente = null;
            }
            else
            {
                aux1 = lista;
                while (aux1.siguiente != null)
                {
                    aux1 = aux1.siguiente;
                }
                aux1.siguiente = nuevoNodo;
                nuevoNodo.siguiente = null;
            }
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

        public int cont()
        {
            int cont = 0;
            Nodo aux = lista;
            while (aux != null)
            {
                cont++;
                aux = aux.siguiente;
            }
            return cont;
        }
        public int elimnar()
        {
            int n = 0;
            if (lista != null)
            {
                Nodo aux = lista;
                n = aux.dato;
                lista = aux.siguiente;
            }
            else
            {
                throw new ArgumentException("Lista vacia");
            }
            return n;
        }
        public void eliminarNodo(int n)
        {
            if (lista != null)
            {
                Nodo auxBorrar = lista;
                Nodo anterior = null;

                while (auxBorrar != null && auxBorrar.dato != n)
                {
                    anterior = auxBorrar;
                    auxBorrar = auxBorrar.siguiente;
                }
                if (auxBorrar == null)
                {
                    Console.WriteLine("Elemento no encontrado");
                }
                else if (anterior == null)
                {
                    lista = lista.siguiente;
                }
                else
                {
                    anterior.siguiente = auxBorrar.siguiente;
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
        public Nodo obtenerPorIndice(int indice)
        {

            int cont = 0;
            if (lista != null && indice <= this.cont() && indice >= 0) 
            {
                Nodo aux = lista;
                if (indice == 0)
                {
                    return aux;
                }
                else
                {
                    while (aux.siguiente != null && cont != indice && indice <= this.cont())
                    {
                        cont++;
                        aux = aux.siguiente;
                    }
                    return aux;
                }
            }
            else
            {
                return null;
            }
        }



        public Nodo aux1;
        public int this[int pIndice]
        {


            get
            {
                aux1 = obtenerPorIndice(pIndice);
                if (aux1 != null)
                {
                    return aux1.dato;
                }
                else
                {
                    throw new ArgumentException("Indec fuera de la mtriz");
                }
                    
                    
                
            }
            set
            {
                try
                {

                    if (lista != null)
                    {
                        aux1 = obtenerPorIndice(pIndice);
                        aux1.dato = value;
                    }
                }
                catch
                {
                    Console.WriteLine("Error fuera de los indice de la matriz");
                }
            }
        }

    }
}
