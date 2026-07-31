using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblLoomProductionMstLog
{
    public int Loomprodnid { get; set; }

    public string? Customer { get; set; }

    public string? Quality { get; set; }

    public string? Category { get; set; }

    public int? QuantitySqm { get; set; }

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

    public DateTime? ActualOffloomDate { get; set; }

    public DateTime? SystemRecordEtd { get; set; }

    public DateTime? CerateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
