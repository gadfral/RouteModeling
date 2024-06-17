using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteModelingCore.Entities;

public sealed class Freight
{
    public string Name { get; set; }

    public string Description { get; set; }

    public long Id { get; set; }

    public Dimensions Dimensions { get; set; }

    public Valuation Valuation { get; set; }
}