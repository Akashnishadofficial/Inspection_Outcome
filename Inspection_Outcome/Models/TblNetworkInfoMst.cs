using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblNetworkInfoMst
{
    public int Id { get; set; }

    public string? ComputerName { get; set; }

    public string? WorkGroupDomain { get; set; }

    public string? UserLoginName { get; set; }

    public string? Password { get; set; }

    public string? UserRight { get; set; }

    public string? Ipaddress { get; set; }

    public string? SubnetMask { get; set; }

    public string? Gateway { get; set; }

    public string? PreferredDns { get; set; }

    public string? AlternetDns { get; set; }

    public string? InternetAccess { get; set; }

    public string? EmailClient { get; set; }

    public string? UserName { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UserId { get; set; }
}
