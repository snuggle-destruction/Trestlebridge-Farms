using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Oat : IResource, ISeedProducing
    {
        private Guid _id = Guid.NewGuid();
        private int _seedsProduced = 70;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public string Type { get; } = "Oat";


        public double Harvest()
        {
            Console.WriteLine($"{Type} {this._shortId} just got {this._seedsProduced}kg of seeds");
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Oat. Dope!";
        }
    }
}