using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblCustShipAddress
{
    public int Id { get; set; }

    public string? CustomerCode { get; set; }

    public string? Srno { get; set; }

    public string? ShipTo { get; set; }

    public string? ShippingCountry { get; set; }

    public string? ShippingState { get; set; }

    public string? ShippingCity { get; set; }

    public string? ShippingStreet { get; set; }

    public long? ShippingZip { get; set; }

    public string? TelNo { get; set; }

    public string? BillTo { get; set; }

    public string? BillingCountry { get; set; }

    public string? BillingState { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingStreet { get; set; }

    public long? BillingZip { get; set; }
}
