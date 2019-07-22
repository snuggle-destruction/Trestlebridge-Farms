using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<ChickenCoop> ChickenCoops { get; } = new List<ChickenCoop>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddPlowedField(PlowedField field)
        {
            PlowedFields.Add(field);
        }

        public void AddChickenCoop(ChickenCoop field)
        {
            ChickenCoops.Add(field);
        }
        public void AddDuckHouse(DuckHouse duckhouse)
        {
            DuckHouses.Add(duckhouse);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            PlowedFields.ForEach(gf => report.Append(gf));
            ChickenCoops.ForEach(gf => report.Append(gf));
            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }
}