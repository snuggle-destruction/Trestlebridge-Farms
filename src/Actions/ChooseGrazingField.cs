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
                    if (farm.GrazingFields[i].animalCount() > 0)
                    {
                        // this asks the field for it's animal list to print if it has more than 0 animals in it
                        Console.WriteLine($"{i + 1}. Grazing Field ({farm.GrazingFields[i].AnimalList()})");
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. Grazing Field");
                    }
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Grazing Field {farm.GrazingFields[i].shortId()} is at capacity.");
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animal.GetType().Name} where?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice != "" && int.TryParse(choice, out int input))
            {
                int animalCount = farm.GrazingFields[input - 1].animalCount();
                if (farm.GrazingFields[input - 1].animalCount() != farm.GrazingFields[input - 1].Capacity)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    farm.GrazingFields[input - 1].AddResource(animal);
                    Console.WriteLine($"Looks like you're the proud owner of a {animal}!");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine($"Grazing Field {farm.GrazingFields[input - 1].shortId()} is daggum full! Y'heer??");
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
            // farm.PurchaseResource<IGrazing>(animal, input);

        }
    }
}