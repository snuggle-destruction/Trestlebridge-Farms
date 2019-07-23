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
                Console.WriteLine($"{i + 1}. Plowed Field");
            }

            Console.WriteLine();

            // How can I output the type of seed chosen here?
            Console.WriteLine($"Place the seed where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            int seedCount = farm.PlowedFields[choice - 1].seedCount();

            if (farm.PlowedFields[choice - 1].seedCount() != farm.PlowedFields[choice - 1].Capacity)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                farm.PlowedFields[choice - 1].AddResource(seed);
                Console.WriteLine($"Looks like you're the proud owner of a single {seed}!");
                Console.WriteLine("\n\n");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine($"Plowed Field {farm.PlowedFields[choice - 1].shortId()} is daggum full! Y'heer??");
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