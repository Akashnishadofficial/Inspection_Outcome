using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblProductionMstLog
{
    public int Prodnid { get; set; }

    public string? Customer { get; set; }

    public string? CustomerPono { get; set; }

    public string? SrNo { get; set; }

    public string? Quality { get; set; }

    public string? Category { get; set; }

    public decimal? OrderQntySqm { get; set; }

    public DateTime? CarpetEtd { get; set; }

    public DateTime? TuftingEtd { get; set; }

    public decimal? ProdnRateSqmhr { get; set; }

    public int? NoofTufterAssigned { get; set; }

    public decimal? DaysNeeded { get; set; }

    public string? TufterCat { get; set; }

    public int? ProdnCompletedSqm { get; set; }

    public int? ProdnRemainingSqm { get; set; }

    public decimal? TuftingTimeHr { get; set; }

    public decimal? ChangeoverTimeHr { get; set; }

    public decimal? TotalHoursNeeded { get; set; }

    public DateTime? ActualLoomDate { get; set; }

    public string? LoomAllocation { get; set; }

    public DateTime? TuftingStartDate { get; set; }

    public DateTime? EstimatedFloomDate { get; set; }

    public string? SuggestedLoomNo { get; set; }

    public DateTime? CerateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
