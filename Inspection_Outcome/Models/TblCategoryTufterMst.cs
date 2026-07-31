using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblCategoryTufterMst
{
    public int CatTufterid { get; set; }

    public string? Category { get; set; }

    public int? TufterCat { get; set; }

    public int? EffectiveTufterCat { get; set; }

    public DateTime? CerateDate { get; set; }

    public DateTime? Modifydate { get; set; }

    public int? Userid { get; set; }
}
