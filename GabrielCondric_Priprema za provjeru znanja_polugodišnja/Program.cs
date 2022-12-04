using System;
namespace PripremaIspit_Trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

        pocetak:
            Console.WriteLine("Unesi stranicu A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi stranicu B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi stranicu C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Stranica nema smisleni broj, pokusaj ponovo.");
                goto pocetak;
            }
            else
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) Console.WriteLine("Zadane stranice su stranice pravokutnog trokuta.");
                else Console.WriteLine("Zadane stranice nisu stranice pravokutnog trokuta.");
            }
            Console.ReadKey();

        }
    }
}
