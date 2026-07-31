using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class Vendarmaster
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? SecondName { get; set; }

    public string? Address { get; set; }

    public string? Mobile { get; set; }

    public string Unit { get; set; } = null!;

    public string? Email { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDt { get; set; }
}
