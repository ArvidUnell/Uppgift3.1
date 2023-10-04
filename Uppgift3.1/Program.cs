using System;

namespace Uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din ålder i hela år?");
            byte ålder = byte.Parse(Console.ReadLine());

            if (ålder < 16)
            {
                Console.WriteLine("Du får inte vara med i tävlingen eftersom du är för ung.");
            }
            else if (ålder > 19)
            {
                Console.WriteLine("Du får inte vara med i tävlingen eftersom du är för gammal.");
            }
            else
            {
                Console.WriteLine("Du får vara med i tävlingen!");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}