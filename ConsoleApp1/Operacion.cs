using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operacion
    {
        static public int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        internal static object Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        internal static object Multiplicar(int numero1, int numero2)
        {
            throw new NotImplementedException();
        }

        internal static object Restar(int numero1, int numero2)
        {
            throw new NotImplementedException();
        }
    }
}
