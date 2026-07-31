using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblPacking
{
    public int Id { get; set; }

    public string? CustomerCode { get; set; }

    public string? OrderNo { get; set; }

    public int? Pcs { get; set; }

    public string? Mode { get; set; }

    public string? Packing { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryByDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateByDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? DespDate { get; set; }
}
