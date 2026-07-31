using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblQuotationMst
{
    public int Id { get; set; }

    public string? EnqNo { get; set; }

    public string? ClientCode { get; set; }

    public string? AreaName { get; set; }

    public string? Material { get; set; }

    public string? Qlty { get; set; }

    public string? SubQlty { get; set; }

    public string? Texture { get; set; }

    public string? Type { get; set; }

    public string? Category { get; set; }

    public int? WidthFt { get; set; }

    public int? WidthInch { get; set; }

    public int? LengthFt { get; set; }

    public int? LengthInch { get; set; }

    public int? Pcs { get; set; }

    public decimal? AreaSqm { get; set; }

    public decimal? TotalAreaSqm { get; set; }

    public decimal? RateSqm { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }

    public string? Uom { get; set; }
}
