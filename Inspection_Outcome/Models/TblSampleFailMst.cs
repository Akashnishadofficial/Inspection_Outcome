using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleFailMst
{
    public int Id { get; set; }

    public int? SampleId { get; set; }

    public string? SrNo { get; set; }

    public string? ClientNo { get; set; }

    public int? SampleNo { get; set; }

    public string? SampleRefNo { get; set; }

    public string? Reason { get; set; }

    public string? DyerName { get; set; }

    public string? WeaverName { get; set; }

    public string? DesignerName { get; set; }

    public string? Csname { get; set; }

    public string? Status { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }
}
