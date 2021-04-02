using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number!");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite subject");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math");
                    break;
                case "Art":
                    Console.WriteLine("Art");
                    break;
                case "History":
                    Console.WriteLine("History");
                    break;
                case "Science":
                    Console.WriteLine("Science");
                    break;
                default:
                    Console.WriteLine("New Subject");
                    break;

            }

        }
    }
}
