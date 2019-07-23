using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural field");
            Console.WriteLine("4. Chicken Coop");
            Console.WriteLine("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            if (input != "")
            {
                switch (Int32.Parse(input))
                {
                    case 1:
                        farm.AddGrazingField(new GrazingField());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("You've created a Grazing Field! Now go'on'n'git'ta'plantin'!");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        farm.AddPlowedField(new PlowedField());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("You've created a Plowed Field! Now go'on'n'git'ta'plantin'!");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        farm.AddNaturalField(new NaturalField());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("You've created a Natural Field! Now go'on'n'git'ta'plantin'!");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case 4:
                        farm.AddChickenCoop(new ChickenCoop());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("You've created a Chicken Coop! You can put a chicken in there!");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case 5:
                        farm.AddDuckHouse(new DuckHouse());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("You've created a Duck House! You can put a Duck in there!");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You entered nothing. And that's wrong. You're bad.");
                Console.WriteLine("\n\n");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
        }
    }
}