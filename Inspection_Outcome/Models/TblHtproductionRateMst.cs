using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblHtproductionRateMst
{
    public int Prdratid { get; set; }

    public string? Quality { get; set; }

    public string? Category { get; set; }

    public decimal? PerHr { get; set; }

    public string? Uom { get; set; }

    public DateTime? CerateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
