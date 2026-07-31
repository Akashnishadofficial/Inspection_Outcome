using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleAck
{
    public int Id { get; set; }

    public string? Srno { get; set; }

    public int? NoRetainerSample { get; set; }

    public string? Uom { get; set; }

    public int? WdthFt { get; set; }

    public int? WdthInch { get; set; }

    public int? LnthFt { get; set; }

    public int? LnthInch { get; set; }

    public int? SampleNo { get; set; }

    public DateOnly? Etd { get; set; }

    public string? RemarkSale { get; set; }

    public DateOnly? ExFactoryDt { get; set; }

    public string? RemarkFactory { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public DateTime? DispatchDt { get; set; }

    public DateTime? LabelDt { get; set; }

    public string? TrackNo { get; set; }

    public string? Courier { get; set; }

    public int? DispatchPcs { get; set; }

    public string? RefSampleNo { get; set; }

    public DateTime? ProcessingDt { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedt { get; set; }

    public int? SampleSrno { get; set; }

    public string? Status { get; set; }

    public string? PreHoldStatus { get; set; }

    public bool IsOrder { get; set; }

    public string? Remark { get; set; }

    public string? Weaver { get; set; }

    public bool? IsRobotuft { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? Flage { get; set; }

    public DateTime? FlageDate { get; set; }

    public string? DispatchBy { get; set; }

    public DateOnly? TraceDt { get; set; }
}
