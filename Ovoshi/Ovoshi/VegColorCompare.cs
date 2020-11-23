using System;
using System.Collections.Generic;
using System.Text;

namespace Ovoshi
{
    class VegColorCompare : IComparer<Vegetable>
    {
        public int Compare( Vegetable left, Vegetable right)
        {
            return left.Color.CompareTo(right.Color);
        }
    }
}
