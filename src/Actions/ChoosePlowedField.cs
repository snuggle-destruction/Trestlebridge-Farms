using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Console.Clear();

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                if (farm.PlowedFields[i].seedCount() != farm.PlowedFields[i].Capacity)
                {


                    if (farm.PlowedFields[i].seedCount() > 0)
                    {
                        Console.WriteLine($"{i + 1}. Plowed Field ({farm.PlowedFields[i].SeedList()})");
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. Plowed Field {farm.PlowedFields[i]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Plowed Field {farm.PlowedFields[i].shortId()}");
                }
            }

            Console.WriteLine();

            // How can I output the type of seed chosen here?
            Console.WriteLine($"Place the seed in which plowed field?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice != "" && int.TryParse(choice, out int input))
            {
                int seedCount = farm.PlowedFields[input - 1].seedCount();
                if (farm.PlowedFields[input - 1].seedCount() != farm.PlowedFields[input - 1].Capacity)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    farm.PlowedFields[input - 1].AddResource(seed);
                    Console.WriteLine($"Looks like you're the proud owner of a single {seed}!");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine($"Plowed Field {farm.PlowedFields[input - 1].shortId()} is daggum full! Y'heer??");
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
            // farm.PurchaseResource<IGrazing>(seed, choice);

        }
    }
}