using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inspection_Outcome.Models;

public partial class TblDesignReqDtl
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? CustPoNo { get; set; }

    public string? SrNo { get; set; }

    public string? AreaCode { get; set; }

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
    [NotMapped]
    public string? Entryby { get; set; }

    public string? ReturnRemark { get; set; }

    public string? ArtworkNo { get; set; }

    public string? AwComments { get; set; }

    public DateTime? HoldDt { get; set; }

    public string? HoldRemark { get; set; }

    public string? Qlty { get; set; }

    public string? SubQlty { get; set; }

    public decimal? InvArea { get; set; }

    public decimal? CstmArea { get; set; }

    public DateOnly? ReqDate { get; set; }

    public DateOnly? EmailRecDate { get; set; }

    public DateTime? ReturndtToHod { get; set; }

    public int? Pcs { get; set; }

    public string? Type { get; set; }

    public DateTime? Revisedt { get; set; }

    public DateTime? UrgentAppdt { get; set; }

    public string? UrgentAppby { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelBy { get; set; }

    public bool? MachineUnit { get; set; }

    public string? CancleRemark { get; set; }

    public string? PreHoldStatus { get; set; }

    public string? HoldBy { get; set; }

    public string? ConvertToPd { get; set; }

    public decimal? TotalArea { get; set; }

    public decimal? ShapeArea { get; set; }

    public string? AttachmentFile { get; set; }

    public string? AttachmentPath { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public DateTime? HoldRealesedt { get; set; }

    public string? Material { get; set; }

    public string? Texture { get; set; }

    public string? JobWorkType { get; set; }

    public string? RefArtworkNo { get; set; }

    public DateTime? Reviseemaildt { get; set; }
}
