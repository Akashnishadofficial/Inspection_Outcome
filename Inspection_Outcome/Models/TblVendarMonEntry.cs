using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblVendarMonEntry
{
    public int Id { get; set; }

    public int? DocNo { get; set; }

    public DateTime? Prodate { get; set; }

    public int? VendarId { get; set; }

    public string? VendarName { get; set; }

    public string? OrderNumber { get; set; }

    public string? Purzano { get; set; }

    public string? Shade { get; set; }

    public string? Material { get; set; }

    public string? Description { get; set; }

    public decimal? FactIssueQnty { get; set; }

    public decimal? ReceivedFinal { get; set; }

    public decimal? QuantityFinal { get; set; }

    public string? Remarks { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }

    public string? GatePassNo { get; set; }

    public decimal? ReturnQty { get; set; }

    public int? MixNo { get; set; }

    public string? EntryType { get; set; }

    public int? Ply { get; set; }

    public string? Designno { get; set; }

    public string? Unit { get; set; }
}
