using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblTwistReceiveEntry
{
    public int Id { get; set; }

    public int? IssId { get; set; }

    public string? OrderNo { get; set; }

    public decimal? TwistIssueQnty { get; set; }

    public decimal? TwistReceiveQnty { get; set; }

    public decimal? LossQty { get; set; }

    public decimal? ReturnQty { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? GatePassNo { get; set; }
}
