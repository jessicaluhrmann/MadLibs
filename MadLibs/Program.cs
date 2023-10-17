namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Creates a functional Mad Libs program
            Author: Me
            */

            // Let the user know that the program is starting:
            Console.WriteLine("The program is starting.");

            // Give the Mad Lib a title:
            var title = "Story";

            Console.WriteLine(title);

            // Define user input and variables:
            Console.WriteLine("Enter a name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            var adj1 = Console.ReadLine();

            Console.WriteLine("Enter a second adjective: ");
            var adj2 = Console.ReadLine();

            Console.WriteLine("Enter a third adjective: ");
            var adj3 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            var verb = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            var noun1 = Console.ReadLine();

            Console.WriteLine("Enter a second noun: ");
            var noun2 = Console.ReadLine();

            Console.WriteLine("Enter an animal: ");
            var animal = Console.ReadLine();

            Console.WriteLine("Enter a food: ");
            var food = Console.ReadLine();

            Console.WriteLine("Enter a fruit: ");
            var fruit = Console.ReadLine();

            Console.WriteLine("Enter a superhero: ");
            var superhero = Console.ReadLine();

            Console.WriteLine("Enter a country: ");
            var country = Console.ReadLine();

            Console.WriteLine("Enter a dessert: ");
            var dessert = Console.ReadLine();

            Console.WriteLine("Enter a year: ");
            var year = Console.ReadLine();

            // The template for the story:
            var story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}