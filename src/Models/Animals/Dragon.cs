using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Dragon : IResource, IGrazing, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 18000.25;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 500.4;
        public string Type { get; } = "Dragon";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Dragon {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Dragon {this._shortId}. Roar!";
        }
    }
}