using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BernardLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 40 movies in this list");

            while (Movie.UserContinueSelection == true)
            {   
                var scifi = new Scifi();
                var horror = new Horror();
                var drama = new Drama();
                var animated = new Animated();

                Console.Write("What category are you interested in (1. Scifi, 2. Horror, 3. Drama, 4. Animated)? ");
            var userInput = Console.ReadLine();

                
            if (userInput.Contains("Scifi", StringComparison.InvariantCultureIgnoreCase) || userInput.Contains("1", StringComparison.InvariantCultureIgnoreCase))
            {
                    Console.WriteLine(scifi.Title());
            }
                if (userInput.Contains("Horror", StringComparison.InvariantCultureIgnoreCase) || userInput.Contains("2", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine(horror.Title());
                }
                if (userInput.Contains("Drama", StringComparison.InvariantCultureIgnoreCase) || userInput.Contains("3", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine(drama.Title());
                }
                if (userInput.Contains("Animated", StringComparison.InvariantCultureIgnoreCase) || userInput.Contains("4", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine(animated.Title());
                }
               

                Movie.UserContinue();


            }
        }
    }
}
