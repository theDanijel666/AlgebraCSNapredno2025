﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_i_filtriranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Unesite broj da biste podijelili broj 50: ");
                try
                {
                    int broj = int.Parse(Console.ReadLine());

                    int rez = 50 / broj;

                    Console.WriteLine("50 / {0} = {1}", broj, rez);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Nije moguće dijeliti s 0, pokušajte ponovno!");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Nesipravna operacija");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Nije ispravan format!");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Došlo je do pogreške, pokušajte povnovno...");
                }

                Console.WriteLine();
            }
        }
    }
}
