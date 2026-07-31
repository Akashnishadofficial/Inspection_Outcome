using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblEmployeeMst
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Department { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Companycode { get; set; }

    public bool? Isactive { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? Location { get; set; }

    public string? Photo { get; set; }

    public string? Unit { get; set; }

    public string? FilePath { get; set; }
}
