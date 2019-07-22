using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

public class Duck : IResource, IGrazing
{
    // Fields
    private Guid _id;


    // Properties


    // Constructor
    public Duck()
    {
        _id = Guid.NewGuid();
    }

    private string _shortId
    {
        get
        {
            return this._id.ToString().Substring(this._id.ToString().Length - 6);
        }
    }


    // Methods
    // public double Process(MeatProcessor equipment)
    // {
    //     return 1.7;
    // }

    // public double Process(EggGatherer equipment)
    // {
    //     return 7;
    // }

    // public double Process(FeatherHarvester equipment)
    // {
    //     return 0.5;
    // }

    public override string ToString()
    {
        return $"Duck {_shortId}. Quack!! Quack!! Quack!! Quack!!";
    }

    public double GrassPerDay { get; set; } = .8;
    public string Type { get; } = "Duck";

    // Methods
    public void Graze()
    {
        Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of grass");
    }
}