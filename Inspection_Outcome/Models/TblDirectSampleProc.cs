using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDirectSampleProc
{
    public int Id { get; set; }

    public string? Sampleno { get; set; }

    public string? Clientno { get; set; }

    public string? Quality { get; set; }

    public string? Designno { get; set; }

    public string? Colorno { get; set; }

    public string? Uom { get; set; }

    public string? Shape { get; set; }

    public int? Pcs { get; set; }

    public int? WidthFt { get; set; }

    public int? WidthInch { get; set; }

    public int? LengthFt { get; set; }

    public int? LengthInch { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }

    public bool? Flage { get; set; }

    public string? ExportBy { get; set; }

    public DateTime? ExportDt { get; set; }
}
