using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class Winder
{
    public int Id { get; set; }

    public string? ContactName { get; set; }

    public string? ContactTitle { get; set; }

    public string? Address { get; set; }

    public string? Mobile { get; set; }

    public string Unit { get; set; } = null!;

    public string? Fax { get; set; }

    public string Email { get; set; } = null!;

    public string? City { get; set; }

    public string? Country { get; set; }

    public decimal? Salary { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }
}
