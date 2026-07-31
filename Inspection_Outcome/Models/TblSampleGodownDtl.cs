using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleGodownDtl
{
    public int Id { get; set; }

    public string? CustomerNo { get; set; }

    public string? ProjectName { get; set; }

    public string? Design { get; set; }

    public string? Quality { get; set; }

    public string? Matrial { get; set; }

    public string? SampleNo { get; set; }

    public string? GodownNo { get; set; }

    public string? RackNo { get; set; }

    public string? BaleNo { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryByDate { get; set; }

    public string? EntryByUpdate { get; set; }

    public DateTime? EntryByUpdateDate { get; set; }

    public string? Barcode { get; set; }

    public int? ReqDtlId { get; set; }
}
