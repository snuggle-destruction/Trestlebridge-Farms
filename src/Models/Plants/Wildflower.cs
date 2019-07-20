// wildflowers produce compost 
using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _compostProduced = 30.03;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Wildflower";

        public double GatherCompost()
        {
            System.Console.WriteLine($"{Type} {this._shortId} just got {this._compostProduced}kg of compost");
            return _compostProduced;
        }

        public override string ToString()
        {
            return $"Wildflower. oh geez.";
        }

    }
}