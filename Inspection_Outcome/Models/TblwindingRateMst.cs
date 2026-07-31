using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblwindingRateMst
{
    public int Id { get; set; }

    public string? DocType { get; set; }

    public string? Material { get; set; }

    public string? Description { get; set; }

    public decimal? Rate { get; set; }

    public string? Remarks { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDt { get; set; }
}
