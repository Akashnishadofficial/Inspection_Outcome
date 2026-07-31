using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesignReqMst
{
    public int Id { get; set; }

    public string? DesignType { get; set; }

    public string? CustPono { get; set; }

    public DateOnly? CustPodt { get; set; }

    public string? CustomerNo { get; set; }

    public string? CustomerName { get; set; }

    public string? Quality { get; set; }

    public DateOnly? CustEmailDt { get; set; }

    public string? Designer { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }
    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }

    public string? Currency { get; set; }

    public string? AttachmentPath { get; set; }

    public string? AttachmentFile { get; set; }

    public string? ProjectName { get; set; }

    public string? Uom { get; set; }

    public string? Consignee { get; set; }

    public string? StdType { get; set; }

    public bool? CheckAddress { get; set; }

    public string? EmailSubject { get; set; }

    public string? UserBy { get; set; }
}
