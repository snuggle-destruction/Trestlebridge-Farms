using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if (farm.DuckHouses[i].duckCount() != farm.DuckHouses[i].Capacity)
                {
                    if (farm.DuckHouses[i].duckCount() != farm.DuckHouses[i].Capacity)
                    {
                        Console.WriteLine($"{i + 1}. Duck House ({farm.DuckHouses[i].duckCount()} duck(s))");
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. Duck House {farm.DuckHouses[i]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Duck House {farm.DuckHouses[i].shortId()} is at capacity.");
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animal.GetType().Name} where?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice != "" && int.TryParse(choice, out int input))
            {
                int duckCount = farm.DuckHouses[input - 1].duckCount();
                if (farm.DuckHouses[input - 1].duckCount() != farm.DuckHouses[input - 1].Capacity)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    farm.DuckHouses[input - 1].AddResource(animal);
                    Console.WriteLine("Looks like you're the proud owner of a Duck!");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine($"Duck House {farm.DuckHouses[input - 1].shortId()} is daggum full! Y'heer??");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You entered something that was not an option. And that's wrong. You're bad.");
                Console.WriteLine("\n\n");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}