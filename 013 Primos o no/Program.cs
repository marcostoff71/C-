using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _013_Primos_o_no
{
    class Program
    {
        static void Main(string[] args)
        {
            CPrimos pri1 = new CPrimos();
            pri1.menu();
            try { 
            SqlConnection sq = new SqlConnection("");
                Console.WriteLine("Conexxion exitosa");
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }
            
        }
    }
    public class CPrimos
    {
        delegate bool salu(int n); 
        List<int> numeros = new List<int>();
        public void menu()
        {
            
            int op = 0;
            Console.WriteLine("---Menu---");
            do
            {
                Console.WriteLine("1. Agregar numeros a la lista");
                Console.WriteLine("2. Agregar numeros aleatorios");
                Console.WriteLine("3. Mostrar numero primos con predicados");
                Console.WriteLine("4. Mostrar numero primos sin predicados");
                Console.WriteLine("5. Salir");
                do
                {
                    op = ValidaInt("Escogue una opcion: ");
                } while (op < 1 || op > 5);
                switch (op)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        AgregarAleatorio();
                        break;
                    case 3:
                        MostrarNumerosPrimosConPredicados();
                        break;
                    case 4:
                        MostrarNumerosPrimosSinPre();
                        break;
                 


                }
                Console.WriteLine("Presiona una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (op != 5);
        }
        public void AgregarAleatorio()
        {
            numeros.Clear();
            Random rdn = new Random();
            int cantidad;
            do
            {
                cantidad = ValidaInt("Dame la cantidad: ");
            } while (cantidad < 1);
            for (int i = 0; i < cantidad; i++)
            {
                numeros.Add(rdn.Next(100));
            }
        }
        public void Agregar()
        {
            numeros.Clear();
            int cantidad = 0;
            do
            {

                cantidad = ValidaInt("Dame la cantidad de elementos: ");
            } while (cantidad < 1);
            for (int i = 0; i < cantidad; i++)
            {
                numeros.Add(ValidaInt(string.Format("Dame el numero {0}: ", i + 1)));
            }

        }
        public int ValidaInt(string mensaje)
        {
            bool valor;
            int numFinal;

            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);
            return numFinal;
        }
        public void MostrarNumerosPrimosConPredicados()
        {
            Predicate<int> primos1 = new Predicate<int>(esPrimo);

            if (numeros.Count > 0)
            {
                List<int> primos= new List<int>();
                primos.Clear();
                //primos = numeros.FindAll(a =>
                //{
                //    int cont = 0;
                //    for (int i = 1; i <= a; i++)
                //    {
                //        if (a % i == 0)
                //        {
                //            cont++;
                //        }
                //    }
                //    if (cont == 2) return true;
                //    else return false;
                //});
                primos = numeros.FindAll(primos1);
                Console.WriteLine("Numeros primos");
                primos.ForEach(i => Console.WriteLine(i));
            }
        }
        public void MostrarNumerosPrimosSinPre()
        {
            if (numeros.Count > 0)
            {
                List<int> primos = new List<int>();
                primos.Clear();
                foreach (int num in numeros)
                {
                    if (esPrimo(num))
                    {
                        primos.Add(num);
                    }
                }
                Console.WriteLine("Mostrando numeros primos");
                for (int i = 0; i < primos.Count; i++)
                {
                    //if (esPrimo(numeros[i]))
                    //{
                    //    primos.Add(numeros[i]);
                    //}
                    Console.WriteLine(primos[i]);
                }
            }
        }
        public bool esPrimo(int n)
        {

            int cont = 0;
            for (int i = 1; i <= n; i++)
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
