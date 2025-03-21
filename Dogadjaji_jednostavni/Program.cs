using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_jednostavni
{
    public delegate void DelegatEventHandlera();
    internal class Program
    {
        public static event DelegatEventHandlera Dodaj;
        static void Main(string[] args)
        {
            Dodaj += new DelegatEventHandlera(Njemacka);
            Dodaj += new DelegatEventHandlera(Slovenia);
            Dodaj += new DelegatEventHandlera(Filipini);

            Dodaj.Invoke();
        }

        static void Njemacka()
        {
            Console.WriteLine("Njemačka");
        }

        static void Slovenia()
        {
            Console.WriteLine("Slovenia");
        }

        static void Filipini()
        {
            Console.WriteLine("Filipini");
        }
    }
}
