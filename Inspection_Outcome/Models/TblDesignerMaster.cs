using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblDesignerMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Fname { get; set; }

    public string? Addresh { get; set; }

    public string? Guarantor { get; set; }

    public string? Phone { get; set; }

    public string? Pan { get; set; }

    public string? Acno { get; set; }

    public float? Limit { get; set; }

    public float? Security { get; set; }

    public string? Code { get; set; }

    public bool Blacklisted { get; set; }

    public string? UserName { get; set; }

    public double? Opening { get; set; }

    public string? Companycode { get; set; }
}
