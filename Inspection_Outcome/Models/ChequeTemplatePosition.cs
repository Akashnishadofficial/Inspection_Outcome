using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class ChequeTemplatePosition
{
    public int Id { get; set; }

    public string BankName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public int PosX { get; set; }

    public int PosY { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }
}
