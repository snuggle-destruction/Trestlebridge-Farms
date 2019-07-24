using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _capacity = 3;
        private Guid _id = Guid.NewGuid();

        private List<ICompostProducing> _composts = new List<ICompostProducing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(ICompostProducing compost)
        {
            // TODO: implement this...
            _composts.Add(compost);
        }

        public void AddResource(List<ICompostProducing> composts)
        {
            // TODO: implement this...
            Console.WriteLine("This should do something @ Natural field");
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
                (from compost in _composts
                 group compost by compost.GetType().Name into compostTypeList
                 select new
                 {
                     compostType = compostTypeList.Key,
                     compostCount = compostTypeList.Count()
                 }).ToList();

            typeList.ForEach(type =>
            {
                if (typeList.Count > 1)
                {
                    output.Append($"{type.compostCount} {type.compostType} ");
                }
                else
                {
                    output.Append($"{type.compostCount} {type.compostType}");
                }
            });

            return output.ToString();

        }

        public double GatherCompost()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._composts.Count} compost(s)\n");

            var typeList =
                (from compost in _composts
                 group compost by compost.GetType().Name into compostTypeList
                 select new
                 {
                     compostType = compostTypeList.Key,
                     compostCount = compostTypeList.Count()
                 }
                ).ToList();



            //start here
            typeList.ForEach(type =>
            {
                if (typeList.Count > 1)
                {
                    output.Append($"{type.compostType}s: {type.compostCount}\n ");
                }
                else
                {
                    output.Append($"{type.compostType}s: {type.compostCount}\n");
                }
            });

            return output.ToString();
        }
        public int seedCount()
        {
            return _composts.Count;
        }
    }
}