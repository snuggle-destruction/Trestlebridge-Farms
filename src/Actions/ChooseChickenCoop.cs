using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenCoop
    {
        public static void CollectInput(Farm farm, IGrazing chicken)
        {
            Console.Clear();

            for (int i = 0; i < farm.ChickenCoops.Count; i++)
            {
                if (farm.ChickenCoops[i].animalCount() != farm.ChickenCoops[i].Capacity)
                {
                    if (farm.ChickenCoops[i].animalCount() > 0)
                    {
                        Console.WriteLine($"{i + 1}. Chicken Coop ({farm.ChickenCoops[i].animalCount()} chicken(s))");
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. Chicken Coop {farm.ChickenCoops[i]}");
                    }

                }
                else
                {
                    Console.WriteLine($"{i + 1}. Chicken Coop {farm.ChickenCoops[i].shortId()} is at capacity.");
                }
            }

            Console.WriteLine();

            // How can I output the type of chicken chosen here?
            Console.WriteLine($"Place the {chicken.GetType().Name} where?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice != "" && int.TryParse(choice, out int input))
            {
                int animalCount = farm.ChickenCoops[input - 1].animalCount();
                if (farm.ChickenCoops[input - 1].animalCount() != farm.ChickenCoops[input - 1].Capacity)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    farm.ChickenCoops[input - 1].AddResource(chicken);
                    Console.WriteLine("Looks like you're the proud owner of a Chicken!");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine($"Chicken Coop {farm.ChickenCoops[input - 1].shortId()} is daggum full! Y'heer??");
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
            // farm.PurchaseResource<IGrazing>(chicken, choice);
        }
    }
}