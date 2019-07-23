using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if (farm.GrazingFields[i].animalCount() != farm.GrazingFields[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Grazing Field");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Grazing Field {farm.GrazingFields[i].shortId()} is at capacity.");
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animal} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            int animalCount = farm.GrazingFields[choice - 1].animalCount();

            if (farm.GrazingFields[choice - 1].animalCount() != farm.GrazingFields[choice - 1].Capacity)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                farm.GrazingFields[choice - 1].AddResource(animal);
                Console.WriteLine($"Looks like you're the proud owner of a {animal}!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine($"Grazing Field {farm.GrazingFields[choice - 1].shortId()} is daggum full! Y'heer??");
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