using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _ducks = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IGrazing animal)
        {
            // TODO: implement this...
            _ducks.Add(animal);
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            Console.WriteLine("This should do something @ GrazingField AddResource");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this._ducks.Count} animals\n");
            this._ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}