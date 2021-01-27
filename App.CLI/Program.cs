using System;

namespace App.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] factionList = new string[3] { "Julii", "Brutii", "Scipii" };

            foreach (string item in factionList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\n\n\n");

            foreach (string item in args)
            {
                Console.WriteLine(item);
            }


        }
    }
}
