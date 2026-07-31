using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblMachinProdnMst
{
    public int Prodnid { get; set; }

    public string? CustomerPono { get; set; }

    public string? SrNo { get; set; }

    public string? Quality { get; set; }

    public string? MachinNo { get; set; }

    public decimal? TufterTimeHr { get; set; }

    public decimal? ChangeoverTimeHr { get; set; }

    public decimal? TotalProdnTimeHr { get; set; }

    public decimal? OrderQntySqm { get; set; }

    public decimal? NoofPcs { get; set; }

    public decimal? WidthM { get; set; }

    public decimal? LengthM { get; set; }

    public decimal? ProdnRateSqmhr { get; set; }

    public DateTime? StartedDate { get; set; }

    public DateTime? RequireDate { get; set; }

    public DateTime? OffLoomDate { get; set; }

    public DateTime? CerateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
