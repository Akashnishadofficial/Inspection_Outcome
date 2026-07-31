using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesignerProcLog
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public string? CratedBy { get; set; }

    public DateTime? CratedDate { get; set; }
}
