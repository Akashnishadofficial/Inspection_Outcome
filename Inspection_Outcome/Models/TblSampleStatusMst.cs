using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleStatusMst
{
    public int Id { get; set; }

    public string? StatusName { get; set; }

    public bool? IsActive { get; set; }

    public string? StatusValue { get; set; }
}
