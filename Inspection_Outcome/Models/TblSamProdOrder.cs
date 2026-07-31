using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSamProdOrder
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public int? Pcs { get; set; }

    public string? Category { get; set; }

    public string? InvoiceType { get; set; }

    public decimal? IrregularArea { get; set; }

    public decimal? RegularArea { get; set; }

    public decimal? Rate { get; set; }

    public string? PriceCaculation { get; set; }

    public string? SubclientName { get; set; }

    public string? CustomerReference { get; set; }

    public string? SideMark { get; set; }

    public string? CodeHk { get; set; }

    public string? ShipMode { get; set; }

    public string? Ddp { get; set; }

    public DateTime? CustEmailAppDt { get; set; }

    public string? LastStatus { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public DateOnly? ExFactoryDt { get; set; }

    public DateOnly? Etd { get; set; }

    public DateTime? TraceDueDt { get; set; }

    public DateTime? DyeingDueDt { get; set; }

    public string? Composition { get; set; }

    public string? Hsn { get; set; }

    public int? Trace { get; set; }

    public int? Chhappi { get; set; }

    public int? Map { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelBy { get; set; }

    public DateTime? ReqDate { get; set; }

    public string? ShippingAddress { get; set; }

    public string? PreHoldStatus { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Freight { get; set; }

    public string? Currency { get; set; }

    public string? Remark { get; set; }

    public DateTime? HoldRealesedt { get; set; }

    public string? HindiRemark { get; set; }

    public int Template { get; set; }

    public int Plen { get; set; }

    public string? ProjectNo { get; set; }

    public string? ColorName { get; set; }
}
