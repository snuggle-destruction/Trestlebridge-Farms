using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Ostrich");
            Console.WriteLine("3. Goat");
            Console.WriteLine("4. Sheep");
            Console.WriteLine("5. Pig");
            Console.WriteLine("6. Dragon");
            Console.WriteLine("7. Duck");
            Console.WriteLine("8. Chicken");
            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string input = Console.ReadLine();

            if (input != "" && int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        if (farm.GrazingFields.Count != 0)
                        {
                            ChooseGrazingField.CollectInput(farm, new Cow());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for your cows!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        if (farm.GrazingFields.Count != 0)
                        {
                            ChooseGrazingField.CollectInput(farm, new Ostrich());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for your ostrichesessss!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        if (farm.GrazingFields.Count != 0)
                        {
                            ChooseGrazingField.CollectInput(farm, new Goat());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for your gorgeous goats!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        if (farm.GrazingFields.Count != 0)
                        {
                            ChooseGrazingField.CollectInput(farm, new Sheep());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for your Shipes!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        if (farm.GrazingFields.Count != 0)
                        {
                            ChooseGrazingField.CollectInput(farm, new Pig());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for your Pigs!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 6:
                        if (farm.GrazingFields.Count != 0)
                        {
                            ChooseGrazingField.CollectInput(farm, new Dragon());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for your Dragons!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 7:
                        if (farm.DuckHouses.Count != 0)
                        {
                            ChooseDuckHouse.CollectInput(farm, new Duck());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("You ain't got no duck house!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 8:
                        if (farm.ChickenCoops.Count != 0)
                        {
                            ChooseChickenCoop.CollectInput(farm, new Chicken());
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for your Chickens!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 0:
                        Console.WriteLine("You know that's not an option.");
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
                Console.WriteLine("You entered something that was not an option. And that's wrong. You're bad.");
                Console.WriteLine("\n\n");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
        }
    }
}