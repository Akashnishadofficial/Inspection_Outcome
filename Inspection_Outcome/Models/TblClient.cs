using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblClient
{
    public int Id { get; set; }

    public string? ClientRecordsType { get; set; }

    public string? ParentClient { get; set; }

    public string? ClientCode { get; set; }

    public string? ClientName { get; set; }

    public string? ShortName { get; set; }

    public string? OwnerShip { get; set; }

    public string? Currency { get; set; }

    public long? Phone { get; set; }

    public string? Brand { get; set; }

    public string? Website { get; set; }

    public string? BusinessGstnno { get; set; }

    public string? PriorityStatus { get; set; }

    public string? ClientSource { get; set; }

    public string? Rating { get; set; }

    public string? ClientSourceOth { get; set; }

    public string? Type { get; set; }

    public string? Industry { get; set; }

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

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Userid { get; set; }

    public bool? AutoEmail { get; set; }

    public int? FollowupMinDays { get; set; }

    public int? FollowupMaxDays { get; set; }
}
