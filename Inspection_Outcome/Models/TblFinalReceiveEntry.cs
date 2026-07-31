using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblFinalReceiveEntry
{
    public int Id { get; set; }

    public int? IssId { get; set; }

    public string? OrderNumber { get; set; }

    public decimal? FinalIssueQnty { get; set; }

    public decimal? FinalReceiveQnty { get; set; }

    public decimal? LossQty { get; set; }

    public decimal? ReturnQty { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? GatePassNo { get; set; }
}
