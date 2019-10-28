using System;

namespace VSCodeTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Dodanie czcionki");


            // Portfolio branch

            System.Console.WriteLine();

            var portfolio = new Portfolio();

            portfolio.AddProject("Teris: Game");

            Console.WriteLine("Added tetris project to portfolio");




        }
    }
}
