using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plesoczki_Á_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            bool van;
            Console.WriteLine("Hányszor dobtunk a kockával?");
            n = Convert.ToInt32(Console.ReadLine());
            int[] dobas = new int[n];
            Console.WriteLine();
            Random rnd = new Random();
            for (i = 0; i < n; i++)
            {
                dobas[i] = rnd.Next(1, 7);
                Console.Write("{0}, ", dobas[i]);
            }
            i = 0;
            while ((i < n) && (!(dobas[i] == 6 && dobas[i + 1] == 6)))
                i++;
            van = i < n;
            if (van)
                Console.WriteLine("\nDobtunk egymás után kétszer hatost.");
            else
                Console.WriteLine("\nNem dobtunk egymás után kétszer hatost.");
            Console.ReadLine();
        }
    }
}
