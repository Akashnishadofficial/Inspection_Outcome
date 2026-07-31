using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleNoReEtdMst
{
    public int Id { get; set; }

    public int? SampleNo { get; set; }

    public DateOnly? SampleEtd { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }
}
