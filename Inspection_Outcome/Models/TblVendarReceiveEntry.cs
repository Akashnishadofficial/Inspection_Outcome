using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblVendarReceiveEntry
{
    public int Id { get; set; }

    public int? IssueId { get; set; }

    public decimal? VendarIssueQnty { get; set; }

    public decimal? VendarReceiveQnty { get; set; }

    public decimal? LossQty { get; set; }

    public decimal? ReturnQty { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? GetPassNo { get; set; }

    public int? MixNo { get; set; }

    public string? OrderNo { get; set; }
}
