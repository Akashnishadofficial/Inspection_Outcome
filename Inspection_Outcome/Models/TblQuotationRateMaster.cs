using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblQuotationRateMaster
{
    public int Id { get; set; }

    public string? MarketSegment { get; set; }

    public string? Construction { get; set; }

    public string? Quality { get; set; }

    public string? YarnType { get; set; }

    public string? Category { get; set; }

    public string? Uom { get; set; }

    public int? Width1 { get; set; }

    public int? Width2 { get; set; }

    public int? Length1 { get; set; }

    public int? Length2 { get; set; }

    public int? Pcs { get; set; }

    public decimal? Area { get; set; }

    public string? PcsBand { get; set; }

    public decimal? Price1 { get; set; }

    public decimal? SpecialPileHeightMm { get; set; }

    public decimal? Price2 { get; set; }

    public string? Texture { get; set; }

    public int? PileLevel { get; set; }

    public string? InstallationType { get; set; }

    public decimal? Price3 { get; set; }

    public string? Carving { get; set; }

    public decimal? Price4 { get; set; }

    public string? MicroTufting { get; set; }

    public decimal? Price5 { get; set; }
}
