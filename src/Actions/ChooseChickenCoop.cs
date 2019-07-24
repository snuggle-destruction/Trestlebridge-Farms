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
                    Console.WriteLine($"{i + 1}. Chicken Coop");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Grazing Field {farm.ChickenCoops[i].shortId()} is at capacity.");
                }
            }

            Console.WriteLine();

            // How can I output the type of chicken chosen here?
            Console.WriteLine($"Place the {chicken.GetType().Name} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            int animalCount = farm.ChickenCoops[choice - 1].animalCount();

            if (farm.ChickenCoops[choice - 1].animalCount() != farm.ChickenCoops[choice - 1].Capacity)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                farm.ChickenCoops[choice - 1].AddResource(chicken);
                Console.WriteLine("Looks like you're the proud owner of a Chicken!");
                Console.WriteLine("\n\n");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine($"Chicken Coop {farm.ChickenCoops[choice - 1].shortId()} is daggum full! Y'heer??");
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