using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblLocationMaster
{
    public int Id { get; set; }

    public string? Location { get; set; }

    public string? InTime { get; set; }

    public string? OutTime { get; set; }

    public string? LunchTimeFrom { get; set; }

    public string? Holiday { get; set; }

    public string? LunchTimeTo { get; set; }
}
