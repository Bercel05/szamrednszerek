using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Szamrendszerek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek, adj meg egy tetszőleges tízes számrendszerbeli egész számot: ");
            int number = int.Parse(Console.ReadLine());

            List<int> kettesSzamrendszer = new List<int>();

            if (number == 0)
            {
                kettesSzamrendszer.Add(0);
            }

            else
            {
                while (number > 0)
                {
                    int maradek = number % 2;
                    kettesSzamrendszer.Add(maradek);
                    number /= 2;
                }
            }

            kettesSzamrendszer.Reverse();
            Console.Write("Ennek a számnak a kettes számrendszere: ");
            foreach (int bit in kettesSzamrendszer)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}



