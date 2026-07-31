using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblProdnPlanningMultiPart
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? MachineNo { get; set; }

    public DateTime? PlanningDate { get; set; }

    public int? Pcs { get; set; }

    public string? Entryby { get; set; }

    public DateTime? Entrydate { get; set; }

    public int? PieceNo { get; set; }

    public string? PieceSrNo { get; set; }

    public bool? IsBooking { get; set; }

    public DateTime? TuftEndDate { get; set; }

    public string? WeavingCategory { get; set; }

    public string? Category { get; set; }

    public string? TuftingDirection { get; set; }

    public int? ShiftsNo { get; set; }

    public bool? Isexit { get; set; }

    public decimal TotalProdnAreaSqm { get; set; }

    public int AddHr { get; set; }

    public bool IsActive { get; set; }

    public decimal TotalHr { get; set; }

    public int? SireealNo { get; set; }

    public string? PartNo { get; set; }

    public bool? Isrobotuftplanning { get; set; }
}
