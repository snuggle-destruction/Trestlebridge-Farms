using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _capacity = 3;
        private Guid _id = Guid.NewGuid();
        private List<ISeedProducing> _seeds = new List<ISeedProducing>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(ISeedProducing seed)
        {
            // TODO: implement this...
            _seeds.Add(seed);
        }
        public string shortId()
        {
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            return shortId;
        }
        public void AddResource(List<ISeedProducing> seeds)
        {
            // TODO: implement this...
            Console.WriteLine("This should do something @ GrazingField AddResource");
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._seeds.Count} seed\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
        public int seedCount()
        {
            return _seeds.Count;
        }
    }
}