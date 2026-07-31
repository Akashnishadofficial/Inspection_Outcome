using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblHtprodnPlanning
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public string? FactoryNo { get; set; }

    public DateTime? PlanningDate { get; set; }

    public string? Entryby { get; set; }

    public DateTime? Entrydate { get; set; }

    public int? Pieces { get; set; }

    public bool? IsBooking { get; set; }

    public DateTime? TuftEndDate { get; set; }

    public bool? Isexit { get; set; }

    public decimal TotalProdnAreaSqm { get; set; }

    public string? OrderNo { get; set; }

    public string? DesignName { get; set; }

    public string? Color { get; set; }

    public string? Quality { get; set; }
}
