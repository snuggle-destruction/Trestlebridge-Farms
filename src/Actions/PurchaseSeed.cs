using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Oat");
            Console.WriteLine("3. Sunflower");
            Console.WriteLine("4. Wildflower");
            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    if (farm.PlowedFields.Count != 0)
                    {
                        ChoosePlowedField.CollectInput(farm, new Sesame());
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for to plantin' your Sesames!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    if (farm.PlowedFields.Count != 0)
                    {
                        ChoosePlowedField.CollectInput(farm, new Oat());
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for to plantin' your Oats!");
                        Console.WriteLine("Press enter, idget!");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    Console.Clear();
                    Console.WriteLine("1. Plowed Field");
                    Console.WriteLine("2. Natural Field");
                    Console.WriteLine();
                    Console.WriteLine("What type of field do you want to plant your sunflowers?");

                    Console.Write("> ");
                    string choice2 = Console.ReadLine();

                    switch (Int32.Parse(choice2))
                    {
                        case 1:
                            if (farm.PlowedFields.Count != 0)
                            {
                                ChoosePlowedField.CollectInput(farm, new Sunflower());
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n");
                                Console.WriteLine("There ain't no field for to plantin' your Sunflowers!");
                                Console.WriteLine("Press enter, idget!");
                                Console.ReadLine();
                                break;
                            }
                        case 2:
                            if (farm.NaturalFields.Count != 0)
                            {
                                ChooseNaturalfield.CollectInput(farm, new Sunflower());
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n");
                                Console.WriteLine("There ain't no field for to plantin' your Sunflowers!");
                                Console.WriteLine("Press enter, idget!");
                                Console.ReadLine();
                                break;
                            }
                        default:
                            break;

                    }
                    break;
                case 4:
                    if (farm.NaturalFields.Count != 0)
                    {
                        ChooseNaturalfield.CollectInput(farm, new Wildflower());
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("There ain't no field for to plantin' your Wildflowers!");
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