using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblHandtuftOrderMst
{
    public int Id { get; set; }

    public string? OrderNo { get; set; }

    public string? SrNo { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsHtplanning { get; set; }

    public bool Isexit { get; set; }
}
