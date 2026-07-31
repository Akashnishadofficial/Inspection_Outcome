using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblFibreMst
{
    public int Id { get; set; }

    public string? Fibre { get; set; }

    public string? Quality { get; set; }

    public string? Category { get; set; }

    public int? Knots { get; set; }

    public string? Quantity { get; set; }

    public int? QntyFrom { get; set; }

    public int? QntyTo { get; set; }

    public string? Unit { get; set; }

    public decimal? Price { get; set; }
}
