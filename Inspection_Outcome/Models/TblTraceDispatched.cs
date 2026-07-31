using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblTraceDispatched
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? OrderNo { get; set; }

    public int? Pcs { get; set; }

    public bool? Trace { get; set; }

    public bool? Map { get; set; }

    public bool? Chhappi { get; set; }

    public bool? Template { get; set; }

    public bool? Plen { get; set; }

    public string? LastStatus { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? ReceiveBy { get; set; }

    public DateTime? ReceiveDt { get; set; }

    public string BarcodeBase64 { get; set; } = null!;

    public bool IsPrint { get; set; }

    public string BarcodeBase641 { get; set; } = null!;

    public int GatePassNo { get; set; }
}
