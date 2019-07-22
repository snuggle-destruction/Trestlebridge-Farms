using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalfield
    {
        public static void CollectInput(Farm farm, ICompostProducing compost)
        {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }

            Console.WriteLine();


            Console.WriteLine($"Place the seed where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.NaturalFields[choice - 1].AddResource(compost);



        }
    }
}