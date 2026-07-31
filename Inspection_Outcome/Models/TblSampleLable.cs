using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleLable
{
    public int Id { get; set; }

    public string? SrNo { get; set; }

    public int? SampleNo { get; set; }

    public string? CustomerNo { get; set; }

    public string? ProjectName { get; set; }

    public string? Design { get; set; }

    public string? Color { get; set; }

    public string? Uom { get; set; }

    public string? Quality { get; set; }

    public string? SubQuality { get; set; }

    public string? Category { get; set; }

    public string? Matrial { get; set; }

    public string? Texture { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryByDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateByDate { get; set; }

    public int? WdthFt { get; set; }

    public int? WdthInch { get; set; }

    public int? LnthFt { get; set; }

    public int? LnthInch { get; set; }

    public string? ItemCode { get; set; }

    public bool IsSelected { get; set; }
}
