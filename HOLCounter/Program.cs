using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!";


            Console.WriteLine("Tere!");
            string hellow = "Hello World!".ToLower();

            int hCounter = 0;

            int oCounter = 0;

            int lCounter = 0;

            for (int i = 0; i < hellow.Length; i++)
            {
                if (hellow[i] == 'h')
                {

                    hCounter++;
                }

            }

            for (int i = 0; i < hellow.Length; i++)
            {
                if (hellow[i] == 'o')
                {

                    oCounter++;
                }
            }

            for (int i = 0; i < hellow.Length; i++)
            {
                if (hellow[i] == 'l')
                {

                    lCounter++;
                }
            }
            Console.WriteLine($"Lauses 'Hello World!' on {hCounter} 'H' täht, {oCounter} 'O' tähte ja {lCounter} 'L' tähte.");

            Console.WriteLine("Ilusat päeva jätku teile!");
        }
    }
}

