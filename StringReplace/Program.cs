using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Hello world!" tärniga (*);

            string hellow = "Hello world!";

            /*for(int i = 0; i < hellow.Length; i++)
            {
                hellow[i] = '*'; //sõnad on muutumatu
            }*/

            hellow = hellow.Replace('o', '*');

            Console.WriteLine(hellow);
        }
}
}
