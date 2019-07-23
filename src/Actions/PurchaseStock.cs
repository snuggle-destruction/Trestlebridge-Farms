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
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    if (farm.GrazingFields.Count != 0)
                    {
                        ChooseGrazingField.CollectInput(farm, new Cow());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        if(farm.GrazingFields[Int32.Parse(choice) - 1].animalCount() == farm.GrazingFields[Int32.Parse(choice) - 1].Capacity)
                        {
                            System.Console.WriteLine("That daggum field is full, y'heer?");
                        }
                        else
                        {
                            Console.WriteLine("Looks like you're the proud owner of a Cow!");
                        }
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for your cows!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    if (farm.GrazingFields.Count != 0)
                    {
                        ChooseGrazingField.CollectInput(farm, new Ostrich());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Looks like you're the proud owner of an Ostrich!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for your ostrichesessss!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    if (farm.GrazingFields.Count != 0)
                    {
                        ChooseGrazingField.CollectInput(farm, new Goat());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Looks like you're the proud owner of a Goat! They're so wonderful. We're so happy for you.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for your gorgeous goats!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    if (farm.GrazingFields.Count != 0)
                    {
                        ChooseGrazingField.CollectInput(farm, new Sheep());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Looks like you're the proud owner of a Sheep!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for your Shipes!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    if (farm.GrazingFields.Count != 0)
                    {
                        ChooseGrazingField.CollectInput(farm, new Pig());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Looks like you're the proud owner of a Pig!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for your Pigs!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    if (farm.GrazingFields.Count != 0)
                    {
                        ChooseGrazingField.CollectInput(farm, new Dragon());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Looks like you're the proud owner of a Dragon!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for your Dragons!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 7:
                    if (farm.DuckHouses.Count != 0)
                    {
                        ChooseDuckHouse.CollectInput(farm, new Duck());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Looks like you're the proud owner of a Duck!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("You ain't got no duck house!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 8:
                    if (farm.ChickenCoops.Count != 0)
                    {
                        ChooseChickenCoop.CollectInput(farm, new Chicken());
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Looks like you're the proud owner of a CHICKEN!!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for your Chickens!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}