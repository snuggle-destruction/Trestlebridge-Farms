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
            string input = Console.ReadLine();

            if (input != "" && int.TryParse(input, out int choice))
            {
                switch (choice)
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
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
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
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        Console.Clear();
                        if (farm.PlowedFields.Count != 0 && farm.NaturalFields.Count != 0)
                        {
                            Console.WriteLine("1. Plowed Field");
                            Console.WriteLine("2. Natural Field");
                            Console.WriteLine();
                            Console.WriteLine("What type of field do you want to plant your sunflowers?");
                        }
                        else if (farm.PlowedFields.Count != 0)
                        {
                            Console.WriteLine("1. Plowed Field");
                            Console.WriteLine();
                            Console.WriteLine("What type of field do you want to plant your sunflowers?");
                        }
                        else if (farm.NaturalFields.Count != 0)
                        {
                            Console.WriteLine("2. Natural Field");
                            Console.WriteLine();
                            Console.WriteLine("What type of field do you want to plant your sunflowers?");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("There ain't no field for to plantin' your Sunflowers!");
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        };

                        Console.Write("> ");
                        string input2 = Console.ReadLine();

                        if (input2 != "" && int.TryParse(input2, out int choice2))
                        {
                        switch (choice2)
                        {
                            case 1:
                                if (farm.PlowedFields.Count != 0)
                                {
                                    ChoosePlowedField.CollectInput(farm, new Sunflower());
                                }
                                break;
                            case 2:
                                if (farm.NaturalFields.Count != 0)
                                {
                                    ChooseNaturalfield.CollectInput(farm, new Sunflower());
                                }
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
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
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