using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblProductionAcktemp
{
    public int Id { get; set; }

    public string? Srno { get; set; }

    public DateOnly? Etd { get; set; }

    public string? RemarkSale { get; set; }

    public DateOnly? ExFactoryDt { get; set; }

    public string? RemarkFactory { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedt { get; set; }
}
