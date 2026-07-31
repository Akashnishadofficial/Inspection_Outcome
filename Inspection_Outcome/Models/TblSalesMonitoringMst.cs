using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSalesMonitoringMst
{
    public int Id { get; set; }

    public string? ClientCode { get; set; }

    public string? EnqNo { get; set; }

    public DateTime? EnquiryDate { get; set; }

    public string? ClientName { get; set; }

    public string? ProjectName { get; set; }

    public string? ArchitectName { get; set; }

    public string? FirmName { get; set; }

    public long? ContectNo { get; set; }

    public string? EmailId { get; set; }

    public string? Address { get; set; }

    public string? LeadFrom { get; set; }

    public decimal? TotalQntySqm { get; set; }

    public decimal? EstimatedValue { get; set; }

    public string? Currency { get; set; }

    public string? Status { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public decimal? ConvertedValue { get; set; }

    public string? Remarks { get; set; }

    public decimal? SampleCourierCost { get; set; }

    public DateTime? LastFollowupDate { get; set; }

    public string? Csname { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }

    public string? Uom { get; set; }
}
