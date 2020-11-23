using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ovoshi
{
    class VegWeightCompare : IComparer<Vegetable>
    {
        public int Compare([AllowNull] Vegetable left, [AllowNull] Vegetable right)
        {
            return left.Weight - right.Weight;
        }
    }
}
