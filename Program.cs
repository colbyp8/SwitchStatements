using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            Console.WriteLine("Type your answer here: ");
            string fav = Console.ReadLine();
            fav =  fav.ToUpper();
            switch (fav)
            {
                case "MATH":
                    Console.WriteLine("Nice! Math is my favorite subject too.");
                    break;
                case "READING":
                    Console.WriteLine("Reading was not always something I was fond of. But I enjoy it as a hobby now.");
                    break;
                case "SCIENCE":
                    Console.WriteLine("Ohhhh, science has always been super interesting to me. Especially involving space.");
                    break;
                case "HISTORY":
                    Console.WriteLine("I can definitely understand your choice. History is one of the most important subjects. I wish more people valued what we can learn from those that came before us.");
                    break;
                case "ART":
                    Console.WriteLine("Only an artist would say that, I'd love to see some of your art I bet it's amazing.");
                    break;
                default:
                    Console.WriteLine("Well that is certainly a subject out of the norm. How interesting.");
                    break;
            }
        }
    }
}
