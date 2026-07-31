using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblTraceProce
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public bool? Trace { get; set; }

    public bool? Map { get; set; }

    public string? LastStatus { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool IsPlan { get; set; }

    public string? MachineNo { get; set; }

    public DateTime? SubmitDt { get; set; }

    public string? SubmitBy { get; set; }

    public int? TraceQty { get; set; }

    public bool Isexit { get; set; }

    public string? OrderNo { get; set; }

    public DateOnly? ReqdDate { get; set; }

    public int? SampleNo { get; set; }

    public bool? Chhappi { get; set; }

    public bool IsTrace { get; set; }

    public bool IsExist { get; set; }

    public bool Template { get; set; }

    public bool Plen { get; set; }

    public DateTime? InProgressDt { get; set; }

    public string? DesignerName { get; set; }

    public DateTime? AllocateDt { get; set; }

    public string? Approvedby { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public DateTime? ReceveDt { get; set; }

    public DateTime? HoldDt { get; set; }

    public int? EstHrs { get; set; }

    public DateTime? SystemEtd { get; set; }

    public DateTime? Etd { get; set; }

    public string? AllocatedBy { get; set; }

    public DateTime? BookingDt { get; set; }

    public string? BookingBy { get; set; }
}
