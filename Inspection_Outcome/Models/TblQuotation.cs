using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblQuotation
{
    public int Quoteid { get; set; }

    public string? QuotationName { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public string? Status { get; set; }

    public string? ProjectName { get; set; }

    public string? Currency { get; set; }

    public string? AccountName { get; set; }

    public int? Brand { get; set; }

    public bool? OverAllDiscount { get; set; }

    public bool? RatePersq { get; set; }

    public bool? FreightCharge { get; set; }

    public bool? ProductDiscount { get; set; }

    public bool? AllPricess { get; set; }

    public bool? InstallationType { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? DiscountPerc { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? Subtotal { get; set; }

    public string? Tax { get; set; }

    public decimal? TaxInPercantage { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? ContactName { get; set; }

    public int? Phone { get; set; }

    public decimal? Email { get; set; }

    public string? BillName { get; set; }

    public string? ShipName { get; set; }

    public string? BillCity { get; set; }

    public string? ShipCity { get; set; }

    public string? BillStreets { get; set; }

    public string? ShipStreets { get; set; }

    public string? BillZip { get; set; }

    public string? ShipZip { get; set; }

    public string? BillState { get; set; }

    public string? ShipState { get; set; }

    public string? BillCountry { get; set; }

    public string? ShipCountry { get; set; }

    public string? Notes { get; set; }

    public string? TermCondition { get; set; }

    public int? Userid { get; set; }
}
