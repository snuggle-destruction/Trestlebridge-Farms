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
            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                // case 2:
                //     ChooseGrazingField.CollectInput(farm, new Ostrich());
                //     break;
                case 3:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                // case 3:
                //     ChooseGrazingField.CollectInput(farm, new Goat());
                //     break;
                // case 4:
                //     ChooseGrazingField.CollectInput(farm, new Sheep());
                //     break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                // case 6:
                //     ChooseGrazingField.CollectInput(farm, new Dragon());
                //     break;
                case 7:

                    //! This logic only allow purchase of a duck if Duck House exists, and otherwise returns them to the main menu.
                    if (farm.DuckHouses.Count != 0)
                    {
                        ChooseDuckHouse.CollectInput(farm, new Duck());
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You ain't got no duck house!");
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