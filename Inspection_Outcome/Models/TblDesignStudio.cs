using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesignStudio
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public int? EstHrs { get; set; }

    public DateTime? Etd { get; set; }

    public DateTime? SystemEtd { get; set; }

    public string? DesignerAllocation { get; set; }

    public string? SystemRecdt { get; set; }

    public DateTime? EstimatedComplDate { get; set; }

    public string? Remark { get; set; }

    public string? AttachmentPath { get; set; }

    public string? AttachmentFile { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public string? LastStatus { get; set; }

    public DateTime? Allocatedt { get; set; }

    public DateTime? ReturndtbyDesigner { get; set; }

    public DateTime? Submitdt { get; set; }

    public DateTime? Receiveddt { get; set; }

    public string? ReturnRemark { get; set; }

    public int? WhiteAreaPerc { get; set; }

    public DateTime? InProgressDt { get; set; }

    public DateTime? ReviseEtd { get; set; }

    public DateTime? EmailRecievedDt { get; set; }

    public DateTime? ReturnDtbysales { get; set; }

    public DateTime? Recalldt { get; set; }

    public DateTime? Rejectdt { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? PreHoldStatus { get; set; }

    public bool IsSelected { get; set; }

    public int SrNoPart { get; set; }

    public int AdisnEstHrs { get; set; }

    public DateTime? AdisnEstHrsDate { get; set; }

    public DateTime? OldSystemEtd { get; set; }

    public DateTime? OldEtd { get; set; }

    public string? RefSrno { get; set; }

    public string? OldDesigner { get; set; }
}
