using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_s_kvadratom_i_mnozenjem
{
    delegate double DoubleOperacija(double x);
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleOperacija[] operacije =
            {
                MatematickeOperacije.Mnozenje,
                MatematickeOperacije.Kvadrat
            };

            for (int i = 0; i < operacije.Length; i++) 
            {
                Console.WriteLine("Operacija[{0}]: ",i);
                IzracunajIPrikazi(operacije[i], 5.0);
                IzracunajIPrikazi(operacije[i], 16.9);
                IzracunajIPrikazi(operacije[i], 1.7432);
                Console.WriteLine();
            }
        }

        static void IzracunajIPrikazi(DoubleOperacija o,double broj)
        {
            double rez = o(broj);
            Console.WriteLine("Broj: {0}   Rezultat: {1}",broj,rez);
        }
    }

    public class MatematickeOperacije
    {
        public static double Mnozenje(double broj)
        {
            return broj * 2;
        }

        public static double Kvadrat(double broj)
        {
            return broj * broj;
        }
    }
}
