using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Comparers
{
    internal class DimensionsComparer : IComparer<Dimensions>
    {
        public int Compare(Dimensions x, Dimensions y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;

            var heightComparison = x.Height.CompareTo(y.Height);
            if (heightComparison != 0) return heightComparison;
            var widthComparison = x.Width.CompareTo(y.Width);
            if (widthComparison != 0) return widthComparison;
            return x.Length.CompareTo(y.Length);
        }
    }
}
