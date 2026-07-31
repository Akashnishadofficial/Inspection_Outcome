using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesignReqDtlTemp
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? CustPoNo { get; set; }

    public string? SrNo { get; set; }

    public string? ProjectName { get; set; }

    public string? DesignName { get; set; }

    public string? Color { get; set; }

    public string? Shape { get; set; }

    public string? Uom { get; set; }

    public int? WdthFt { get; set; }

    public int? WdthInch { get; set; }

    public int? LnthFt { get; set; }

    public int? LnthInch { get; set; }

    public string? CustInstruction { get; set; }

    public string? LastStatus { get; set; }

    public DateTime? Allocateddt { get; set; }

    public DateTime? ReturndtbyHod { get; set; }

    public DateTime? CustSubmitdt { get; set; }

    public DateTime? CustApproveddt { get; set; }

    public DateTime? Receiveddt { get; set; }

    public string? Entryby { get; set; }

    public string ReturnRemark { get; set; } = null!;

    public string? ArtworkNo { get; set; }

    public string? AwComments { get; set; }

    public DateTime? HoldDt { get; set; }

    public string? HoldRemark { get; set; }

    public string? Qlty { get; set; }

    public string? SubQlty { get; set; }

    public decimal? CstmArea { get; set; }

    public DateOnly? ReqDate { get; set; }

    public string? AreaCode { get; set; }

    public int? Pcs { get; set; }

    public string? Type { get; set; }

    public decimal? InvArea { get; set; }

    public string? Material { get; set; }

    public string? Texture { get; set; }
}
