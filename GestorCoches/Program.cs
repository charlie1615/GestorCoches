using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche co = new Coche();
            Coche co2 = new Coche();
            Console.WriteLine(Coche.Numero);
            int resultado = Calculadora.Sumar(5, 8);
            Console.WriteLine(resultado);
            Console.ReadKey();

        }

    }
}
