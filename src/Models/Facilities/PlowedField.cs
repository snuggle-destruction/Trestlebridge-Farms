using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

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
        public string SeedList()
        {
            StringBuilder output = new StringBuilder();

            var typeList =
                (from seed in _seeds
                 group seed by seed.GetType().Name into seedTypeList
                 select new
                 {
                     seedType = seedTypeList.Key,
                     seedCount = seedTypeList.Count()
                 }).ToList();

            typeList.ForEach(type =>
            {
                if (typeList.Count > 1)
                {
                    output.Append($"{type.seedCount} {type.seedType} ");
                }
                else
                {
                    output.Append($"{type.seedCount} {type.seedType}");
                }
            });

            return output.ToString();

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
            // this._seeds.ForEach(a => output.Append($"   {a}\n"));
            var typeList =
                (from seed in _seeds
                 group seed by seed.GetType().Name into seedTypeList
                 select new
                 {
                     seedType = seedTypeList.Key,
                     seedCount = seedTypeList.Count()
                 }
                ).ToList();

            typeList.ForEach(type =>
            {
                if (type.seedType == "Sesame")
                {
                    output.Append($"{type.seedType} seeds: {type.seedCount}\n");
                }
                else
                {
                    output.Append($"{type.seedType}s: {type.seedCount}\n");
                }
            });
            return output.ToString();
        }

        public int seedCount()
        {
            return _seeds.Count;
        }
    }
}