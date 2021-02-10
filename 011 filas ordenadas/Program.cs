using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_filas_ordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista1 = new Lista();
            lista1.Agregar(10);
            lista1.Agregar(2);
            lista1.Agregar(3);
            lista1.Agregar(4);
            lista1.Agregar(5);
            lista1.Agregar(6);
            lista1.Agregar(7);
            lista1.Mostrar();
        }
    }
}
