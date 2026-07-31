using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblTraceBooking
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? MachineNo { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? Shifting { get; set; }

    public int? PieceNo { get; set; }

    public decimal? PendingQnty { get; set; }

    public string? Entryby { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Uom { get; set; }

    public decimal? TotalQty { get; set; }

    public string? TraceName { get; set; }
}
