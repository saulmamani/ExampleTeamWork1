using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------EJEMPLO DE TRABAJO EN EQUIPO CON GIT Y GITHUB--------");

            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La suma es: { Operacion.Sumar(numero1, numero2) }");
            Console.WriteLine($"La resta es: {Operacion.Restar(numero1, numero2) }");
            Console.WriteLine($"La multiplicacion es: { Operacion.Multiplicar(numero1, numero2) }");
            Console.WriteLine($"La division es: { Operacion.Dividir(numero1, numero2) }");

            Console.ReadKey();
        }
    }
}
