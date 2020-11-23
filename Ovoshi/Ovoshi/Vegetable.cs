using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ovoshi
{
    public class Vegetable : IComparable<Vegetable>
    {
        public int Calories;
        public int Weight;
        public string Color;
        public string Name;

        public int CompareTo(Vegetable other)
        {
            return Name.CompareTo(other.Name);   
        }
    }
}
