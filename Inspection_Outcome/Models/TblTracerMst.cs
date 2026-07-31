using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblTracerMst
{
    public int Tufterid { get; set; }

    public string? Category { get; set; }

    public string? TufterCat { get; set; }

    public DateTime? DateOccupied { get; set; }

    public DateTime? CerateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
