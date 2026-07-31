using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDailyProduction
{
    public int Dailyprodnid { get; set; }

    public int? Prodnid { get; set; }

    public string? PurchaseNo { get; set; }

    public DateTime? DalyProdnDate { get; set; }

    public int? ProdnCompletedSqm { get; set; }

    public int? ProdnRemainingSqm { get; set; }

    public string? TufterName1 { get; set; }

    public string? TufterName2 { get; set; }

    public string? TufterName3 { get; set; }

    public string? TufterName4 { get; set; }

    public string? TufterName5 { get; set; }

    public DateTime? CerateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
