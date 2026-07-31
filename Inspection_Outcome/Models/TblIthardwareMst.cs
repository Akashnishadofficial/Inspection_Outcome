using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblIthardwareMst
{
    public int Id { get; set; }

    public int? SystemSrNo { get; set; }

    public string? MachineName { get; set; }

    public string? CompanyName { get; set; }

    public string? Unit { get; set; }

    public string? DepartmentName { get; set; }

    public string? ItemType { get; set; }

    public string? ModelNo { get; set; }

    public DateTime? Warranty { get; set; }

    public int? Quantity { get; set; }

    public string? SystemStatus { get; set; }

    public string? WarrantyAmc { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public decimal? ItemValue { get; set; }

    public string? Remark { get; set; }

    public string? Category { get; set; }
}
