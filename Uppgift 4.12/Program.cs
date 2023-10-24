using System;

namespace Uppgift_4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm kvadraternas sidlängd.");
            int sidlängd = int.Parse(Console.ReadLine());
            Console.WriteLine("Bestäm rutnätets bredd.");
            int bredd = int.Parse(Console.ReadLine());
            Console.WriteLine("Bestäm rutnätets höjd.");
            int hojd = int.Parse(Console.ReadLine());

            for(int i = 0; i < hojd; i++)
            {
                for(int j = 0; j < bredd; j++)
                {
                    for (int k = 0; k < sidlängd; k++)
                        Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}