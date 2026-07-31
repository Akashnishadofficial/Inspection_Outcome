using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSubClientMaster
{
    public int Id { get; set; }

    public string? CustomeCode { get; set; }

    public string? SubClientCode { get; set; }

    public string? SubClientName { get; set; }

    public string? ShortCode { get; set; }
}
