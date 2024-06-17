using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteModelingCore.Entities;

namespace RouteModelingCore.Context.EntityContext
{
    internal class EntityContext
    {
        public double Weigth { get; set; }

        public Dimensions Dimensions { get; set; }

        public Price Price { get; set; }

        public int Speed { get; set; }
    }
}
