using System;
using System.Collections.Generic;
using System.Text;

namespace Ovoshi
{
    class VegCaloriesCompare : IComparer<Vegetable>
    {
        public int Compare(Vegetable left, Vegetable right)
        {
            return left.Calories - right.Calories;
        }
    }
}
