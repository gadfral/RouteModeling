using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Context.EntityContext
{
    public sealed class EntityContext
    {
        public AutoType AutoType { get; set; }

        public double PermissibleMaximumWeigth { get; set; }

        public Dimensions Dimensions { get; set; }

        public Price Price { get; set; }

        public int Speed { get; set; }
    }
}
