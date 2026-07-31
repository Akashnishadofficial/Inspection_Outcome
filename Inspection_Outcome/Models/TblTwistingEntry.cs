using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblTwistingEntry
{
    public int Id { get; set; }

    public DateOnly? ProdDate { get; set; }

    public int? DocNo { get; set; }

    public int? Rcptid { get; set; }

    public int? MixNo { get; set; }

    public string? VendarName { get; set; }

    public string? OrderNumber { get; set; }

    public decimal? MixtureQnty { get; set; }

    public decimal? TwistIssueQty { get; set; }

    public decimal? TwistRcptQty { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? GatePassNo { get; set; }

    public string? Remarks { get; set; }
}
