using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblProdnBooking
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? MachineNo { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? Shifting { get; set; }

    public int? PieceNo { get; set; }

    public decimal? TotalQntySqm { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Category { get; set; }

    public string? WeavingCategory { get; set; }

    public decimal? ProdnRateSqmhr { get; set; }

    public string? Uom { get; set; }

    public decimal? OneTimeDown { get; set; }

    public decimal? ToalProdnSqm { get; set; }

    public string? TufterName { get; set; }

    public string? Remark { get; set; }
}
