using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleRackMaster
{
    public int Id { get; set; }

    public string? GodownNo { get; set; }

    public string? RackNo { get; set; }

    public string? BaleNo { get; set; }
}
