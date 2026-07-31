using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblCarpetInspection
{
    public int Id { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string ProjectName { get; set; } = null!;

    public string? SrNo { get; set; }

    public string? Quality { get; set; }

    public string? DesignName { get; set; }

    public string? ColorName { get; set; }

    public string? Uom { get; set; }

    public int? Pcs { get; set; }

    public int? WdthFt { get; set; }

    public int? WdthInch { get; set; }

    public int? LnthFt { get; set; }

    public int? LnthInch { get; set; }

    public string? Remarks { get; set; }

    public string Status { get; set; } = null!;

    public string? RejectReason { get; set; }

    public DateTime? DispatchDate { get; set; }

    public DateTime? PassDt { get; set; }

    public DateTime? RejectDt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
