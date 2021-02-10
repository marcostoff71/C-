using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            saludo saluu = new saludo();
            saludos salu1 = new saludos(saluu.hola);
            salu1();
        }

        delegate void saludos();
    }
    class saludo
    {
        public int n;
        public  void hola()
        {
            Console.WriteLine("Hola");
        }
    }
}
