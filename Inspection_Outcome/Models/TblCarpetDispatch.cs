using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblCarpetDispatch
{
    public int Id { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? ProjectName { get; set; }

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

    public string? ShipMode { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public string? RejectRemark { get; set; }

    public DateTime? RejectDate { get; set; }

    public bool IsSentForApproval { get; set; }

    public string? OrderNo { get; set; }
}
