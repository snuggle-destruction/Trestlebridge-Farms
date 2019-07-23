using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 3;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

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
            _animals.Add(animal);
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            Console.WriteLine("This should do something @ GrazingField AddResource");
        }

        public string shortId()
        {
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            return shortId;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            var typeList =
                (from animal in _animals
                 group animal by animal.GetType().Name into animalTypeList
                 select new
                 {
                     animalType = animalTypeList.Key,
                     animalCount = animalTypeList.Count()
                 }
                ).ToList();

            typeList.ForEach(type =>
            {
                // string newType = type.animalType.ToString().Split(".")[3];
                if (type.animalType == "Ostrich")
                {
                    output.Append($"{type.animalType}es: {type.animalCount}\n");
                }
                else
                {
                    output.Append($"{type.animalType}s: {type.animalCount}\n");
                }
            });

            return output.ToString();
        }
        public int animalCount()
        {
            return _animals.Count;
        }
    }
}