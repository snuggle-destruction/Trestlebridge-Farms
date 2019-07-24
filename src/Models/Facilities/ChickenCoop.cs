using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenCoop : IFacility<IGrazing>
    {
        private int _capacity = 3;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _chickens = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IGrazing chicken)
        {
            // TODO: implement this...
            _chickens.Add(chicken);
        }

        public void AddResource(List<IGrazing> chicken)
        {
            // TODO: implement this...
            Console.WriteLine("This should do something @ ChickenCoop AddResource");
        }

        public string shortId()
        {
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            return shortId;
        }

        public string AnimalList()
        {
            // this function is for Adding a list of animals and how many of those animals there are in a field, when the user
            // is given the choice to place an animal in a field
            StringBuilder output = new StringBuilder();



            return output.ToString();

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken Coop {shortId} has {this._chickens.Count} chickens\n");

            return output.ToString();
        }
        public int animalCount()
        {
            return _chickens.Count;
        }
    }
}