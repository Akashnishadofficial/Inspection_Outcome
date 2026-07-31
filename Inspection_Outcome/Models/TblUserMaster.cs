using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblUserMaster
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Firstname { get; set; }

    public string? Secondname { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string Accounttype { get; set; } = null!;

    public string? Department { get; set; }

    public string? Ugroup { get; set; }

    public string? ShortCode { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Companycode { get; set; }

    public int? Roleid { get; set; }

    public string? Fullname { get; set; }

    public bool? Inactive { get; set; }

    public bool? IsLockedOut { get; set; }

    public int? FailedLoginAttempts { get; set; }

    public DateTime? LockoutEndTime { get; set; }

    public int? EntryBy { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? Heading1 { get; set; }

    public string? Heading2 { get; set; }

    public string? Location { get; set; }

    public string? SharedUser { get; set; }

    public int? Parentid { get; set; }

    public string? Photo { get; set; }

    public bool? IsUrgent { get; set; }

    public string? Unit { get; set; }

    public string? SubOrdinate { get; set; }
}
