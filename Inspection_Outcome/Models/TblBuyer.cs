using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblBuyer
{
    public int Id { get; set; }

    public string? Buyercode { get; set; }

    public string? Bno { get; set; }

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? Fax { get; set; }

    public string? Notifyname { get; set; }

    public string? Notifyadd1 { get; set; }

    public string? Bankname { get; set; }

    public string? Bankadd1 { get; set; }

    public string? Portload { get; set; }

    public string? Portdischarge { get; set; }

    public string? Destination { get; set; }

    public string? Finaldestination { get; set; }

    public string? Ratetype { get; set; }

    public string? Measureunit { get; set; }

    public string? Currency { get; set; }

    public string? Phone { get; set; }

    public string? Username { get; set; }

    public DateTime? Datetime { get; set; }

    public int? Itemno { get; set; }

    public string? Companycode { get; set; }

    public string? Portloadsea { get; set; }

    public string? Portdessea { get; set; }

    public int? Sku { get; set; }

    public string? Consigneename { get; set; }

    public string? Consigneeadd { get; set; }

    public string? ShortCode { get; set; }

    public bool? AutoEmail { get; set; }
}
