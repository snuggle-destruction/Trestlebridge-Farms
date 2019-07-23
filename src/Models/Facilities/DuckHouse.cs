using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IGrazing>
    {
        private int _capacity = 3;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _ducks = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public string shortId()
        {
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            return shortId;
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

            output.Append($"Duck House {shortId} has {this._ducks.Count} duck(s)\n");

            return output.ToString();
        }

        public int duckCount()
        {
            return _ducks.Count;
        }
    }
}