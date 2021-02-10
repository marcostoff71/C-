using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Predicados
{
    class Program
    {
        public static Predicate<int> primos = new Predicate<int>(esPrimo);
        static void Main(string[] args)
        {
            //con delegados predicados 
            //List<int> numeros = new List<int>();
            //numeros.AddRange(new int[] { 23, 4, 5, 6, 7, 8, 9, 10 });
            //List<int> numprimos= numeros.FindAll(new Predicate<int>(esPrimo));

            //for(int i = 0; i < numprimos.Count; i++)
            //{
            //    Console.WriteLine(numprimos[i]);
            //}
            //sin 
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 23, 4, 5, 6, 7, 8, 9, 10 });
            numeros.Remove(10);
            numeros.ForEach(i => Console.WriteLine(i));

            int[] numeros1 = new int[]{ 1, 3, 2, 4 };
            Array.Sort(numeros1);

            numeros.ForEach(i => Console.WriteLine(i));
            

            for (int i = 0; i < numeros.Count; i++)
            {
                if (esPrimo(numeros[i]))
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
        static bool esPrimo(int n)
        {
            int cont = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2) return true;
            else return false;
                    
        }
    }
}
