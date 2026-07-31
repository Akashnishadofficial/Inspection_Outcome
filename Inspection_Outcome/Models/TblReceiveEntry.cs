using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblReceiveEntry
{
    public int Id { get; set; }

    public int? IssueId { get; set; }

    public decimal? WinderIssueQnty { get; set; }

    public decimal? WinderReceiveQnty { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }
}
