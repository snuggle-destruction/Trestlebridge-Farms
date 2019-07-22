using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing
    {
        private Guid _id = Guid.NewGuid();
        private int _seedsProduced = 650;
        private double _compostProduced = 21.6;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public string Type { get; } = "Sunflower";

        public double Harvest()
        {
            Console.WriteLine($"{Type} {this._shortId} just got {this._seedsProduced} seeds");
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"{Type} {this._shortId}, aren't these just weeds?";
        }
    }
}