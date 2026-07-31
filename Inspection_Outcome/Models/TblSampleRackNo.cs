using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleRackNo
{
    public int Id { get; set; }

    public string GodownNo { get; set; } = null!;

    public string RackNo { get; set; } = null!;

    public string BaleNo { get; set; } = null!;
}
