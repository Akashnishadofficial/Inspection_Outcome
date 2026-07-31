using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblUserlog
{
    public long Userlogid { get; set; }

    public int? Userid { get; set; }

    public DateTime? Activitydatetime { get; set; }

    public int? Smnuid { get; set; }

    public string? Smenu { get; set; }

    public string? Fieldname { get; set; }

    public string? PrimaryFieldname { get; set; }

    public long? Primaryfieldid { get; set; }

    public string? Eventname { get; set; }
}
