using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesignStudioCancellation
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public string? Designer { get; set; }

    public string? CancelBy { get; set; }

    public DateTime? CancelDt { get; set; }

    public DateTime? AssignDt { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? SystemEtd { get; set; }
}
