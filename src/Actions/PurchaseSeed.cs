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
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;
                case 2:
                    ChoosePlowedField.CollectInput(farm, new Oat());
                    break;
                case 3:
                    ChoosePlowedField.CollectInput(farm, new Sunflower());
                    break;
                case 4:
                    ChooseNaturalfield.CollectInput(farm, new Wildflower());
                    break;
                default:
                    break;
            }
        }
    }
}