using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSerialMaster
{
    public int Id { get; set; }

    public string? Module { get; set; }

    public int? SrNo { get; set; }

    public string? Fy { get; set; }
}
