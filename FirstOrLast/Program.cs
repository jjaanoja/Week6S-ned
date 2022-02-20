using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanime;
            //programm kontrolli andmete pikkust (eraldi);
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi;

            Console.WriteLine("Tere!");
            Console.WriteLine("Palun, sisestage enda eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} tähte.");


            Console.WriteLine("Palun, sisestage enda perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length} tähte.");

            if (firstName.Length < lastName.Length)
            {

                Console.WriteLine("Sinu perekonnanimi on pikem, kuna sisaldab rohkem tähti.");
            }
            else if (firstName.Length > lastName.Length)
            {

                Console.WriteLine("Sinu eesnimi on pikem, kuna sisaldab rohkem tähti.");
            }
            else
            {

                Console.WriteLine("Ees- ja perekonnanimi on sama pikad.");
            }


            Console.WriteLine("Kena päeva!");
        }
    }
}
