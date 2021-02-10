using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Listas_no_ordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista1 = new Lista();
            lista1.Agregar(10);
            lista1.Agregar(9);
            lista1.Agregar(5);
            lista1.Agregar(2);
            lista1.Agregar(23);
            lista1.Agregar(32);
            lista1.Agregar(4);
            lista1.Agregar(5);
            lista1.Agregar(7);
            lista1.Agregar(8);

            lista1.Mostrar();

            
            
            int aux;
            //for (int i = 1; i < lista1.cont(); i++)
            //{
            //    for(int j = 0; j < lista1.cont() - i; j++)
            //    {
            //        if (lista1[j] > lista1[j + 1])
            //        {

            //            aux = lista1[j];
            //            lista1[j] = lista1[j+1];
            //            lista1[j+1] = aux;
            //        }
            //    }
            //}

            //int pos;
            //for(int i = 1; i < lista1.cont(); i++)
            //{
            //    pos = i;
            //    while (pos > 0 && lista1[pos - 1] > lista1[pos])
            //    {
            //        aux = lista1[pos];
            //        lista1[pos] = lista1[pos - 1];
            //        lista1[pos - 1] = aux;
            //        pos--;

            //    }
            //}

            int imin;
            //for(int i = 0; i < lista1.cont(); i++)
            //{
            //    imin = i;
            //    for(int j = i + 1; j < lista1.cont(); j++)
            //    {
            //        if (lista1[j] < lista1[imin])
            //        {

            //            imin = j;
            //        }
            //    }

            //    aux = lista1[i];
            //    lista1[i] = lista1[imin];
            //    lista1[imin] = aux;
            //}
            
            int pos;
            int dato;
            for (int i = 1; i < lista1.cont(); i++)
            {
                
                pos = i;
                dato = lista1[i];
                while (pos > 0 && lista1[pos - 1] > dato)
                {
                    lista1[pos] = lista1[pos - 1];
                    pos--;


                }

                lista1[pos] = dato;
            }
            lista1.Mostrar();

            while (lista1.aux1 != null)
            {

                Console.Write(lista1.aux1.dato);
                lista1.aux1 = lista1.aux1.siguiente;
            }
            //Console.WriteLine(lista1.cont());

            //Random rdn = new Random();
            //List<int> numero = new List<int>();

            //for (int i = 0; i < 10; i++) numero.Add(rdn.Next(1, 100));
            //numero.ForEach(i =>
            //{
            //    if (i % 2 == 0) Console.WriteLine(i);
            //});

            //List<int> primos = numero.FindAll(i =>
            //{
            //    int cont = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0) cont++;
            //    }
            //    if (cont == 2) return true;
            //    else
            //        return false;

            //});

            //Console.WriteLine("numeros primos");
            //primos.ForEach(i => Console.WriteLine(i));

        }
    }
}
