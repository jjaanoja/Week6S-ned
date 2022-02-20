using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic 0-ga;
            //programm asendab kõik 'a' tähed samas lauses 4-ga;

            string panic = "Don't panic";

            panic = panic.Replace('o', '0');

            panic = panic.Replace('a', '4');

            Console.WriteLine(panic);
        }
    }
}
