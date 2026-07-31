using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblFinalEntry
{
    public int Id { get; set; }

    public DateOnly? ProdDate { get; set; }

    public int? DocNo { get; set; }

    public int? Rcptid { get; set; }

    public string? VendarName { get; set; }

    public string? OrderNumber { get; set; }

    public string? Material { get; set; }

    public decimal? TwistQnty { get; set; }

    public decimal? FinalIssueQty { get; set; }

    public decimal? FinaltRcptQty { get; set; }

    public decimal? FinalReturnQty { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? GatePassNo { get; set; }

    public string? Remarks { get; set; }

    public string? EntryType { get; set; }
}
