using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalfield
    {
        public static void CollectInput(Farm farm, ICompostProducing compost)
        {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                if (farm.NaturalFields[i].seedCount() != farm.NaturalFields[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Natural Field {farm.NaturalFields[i].shortId()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Natural Field {farm.NaturalFields[i].shortId()} is at capacity");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Place the {compost.GetType().Name} which natural field?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice != "" && int.TryParse(choice, out int input))
            {
            int seedCount = farm.NaturalFields[input - 1].seedCount();

                
                if (farm.NaturalFields[input - 1].seedCount() != farm.NaturalFields[input - 1].Capacity)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    farm.NaturalFields[input - 1].AddResource(compost);
                    Console.WriteLine($"Looks like you're the proud owner of a {compost}!");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine($"Natural Field {farm.NaturalFields[input - 1].shortId()} is daggum full! Y'heer??");
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
        }
    }
}