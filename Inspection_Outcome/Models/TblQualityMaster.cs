using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblQualityMaster
{
    public int Id { get; set; }

    public string Quality { get; set; } = null!;

    public string? ExQuality { get; set; }

    public string? Alias { get; set; }

    public string? Prefix { get; set; }

    public string? Username { get; set; }
}
