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


            portfolio.AddProject("Netflix imitation project");
            Console.WriteLine("Added fake netflix project to portfolio");


            System.Console.WriteLine("Added new feature #1");
            System.Console.WriteLine("Added new feature #2");
            System.Console.WriteLine("Added new feature #3");

            System.Console.WriteLine("Github pull request");
    }
}
