﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Basicos_de_CSharp___Pink_e_Cerebro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suavariavel = int.Parse(Console.ReadLine());
            string[] n = Console.ReadLine().Split(' ');

            int multiplo2 = 0;
            int multiplo3 = 0;
            int multiplo4 = 0;
            int multiplo5 = 0;
            for (int iContador = 0; iContador < suavariavel; iContador++)
            {
                if ((int.Parse(n[iContador]) % 2) == 0)
                    multiplo2++;
                if ((int.Parse(n[iContador]) % 3) == 0)
                    multiplo3++;
                if ((int.Parse(n[iContador]) % 4) == 0)
                    multiplo4++;
                if ((int.Parse(n[iContador]) % 5) == 0)
                    multiplo5++;
            }

            Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
            Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
            Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
            Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);

            Console.ReadKey();
        }
    }
}
