using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblProjectMst
{
    public int Projectid { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? Contact { get; set; }

    public string? ClientName { get; set; }

    public string? Brand { get; set; }

    public string? LeadSource { get; set; }

    public string? LeadSourceOth { get; set; }

    public string? Business { get; set; }

    public string? Referrer { get; set; }

    public string? UoM { get; set; }

    public decimal? TotalTax { get; set; }

    public string? Corrency { get; set; }

    public DateOnly? ClosedDate { get; set; }

    public string? DeliveryInstallationStatus { get; set; }

    public string? ProjectStatus { get; set; }

    public string? LostReason { get; set; }

    public string? BillingStreet { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public long? BillingZip { get; set; }

    public string? BillingCountry { get; set; }

    public string? ShippingStreet { get; set; }

    public string? ShippingCity { get; set; }

    public string? ShippingState { get; set; }

    public long? ShippingZip { get; set; }

    public string? ShippingCountry { get; set; }

    public int? Userid { get; set; }
}
