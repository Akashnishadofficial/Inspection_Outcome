using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesignerProc
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? LastStatus { get; set; }

    public DateTime? StatusDate { get; set; }

    public string? FilePath { get; set; }

    public string? Filename { get; set; }

    public string? Remark { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public DateTime? Submitdt { get; set; }

    public decimal? Productionarea { get; set; }

    public int? WdthFt { get; set; }

    public int? WdthInch { get; set; }

    public int? LnthFt { get; set; }

    public int? LnthInch { get; set; }

    public DateTime? Holddt { get; set; }

    public int SrNoPart { get; set; }

    public DateTime? ReleaseDt { get; set; }

    public DateTime? RejectDt { get; set; }

    public int? RndprogPer { get; set; }

    public DateOnly? PerDate { get; set; }
}
