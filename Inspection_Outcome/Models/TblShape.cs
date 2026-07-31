using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblShape
{
    public int Id { get; set; }

    public string? Shape { get; set; }

    public string? Carpetno { get; set; }

    public string? Process { get; set; }

    public string? Status { get; set; }

    public string? Companycode { get; set; }

    public int? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }
}
