using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, what is your favorite subject?");
            
            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "english":
                    Console.WriteLine("I'm not that good in English!");
                    break;
                case "science":
                    Console.WriteLine("I enjoy Science!");
                    break;
                case "physics":
                    Console.WriteLine("I'm pretty good in physics");
                    break;
                default:
                    Console.WriteLine("Ah, I haven't taken that subject before!");
                    break;

                
                    

            }

        }
    }
}
