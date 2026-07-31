using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblSampleNoMst
{
    public int Id { get; set; }

    public string? ClientNo { get; set; }

    public string? ClientName { get; set; }

    public string? ProjectName { get; set; }

    public string? CustPono { get; set; }

    public string? HandleBy { get; set; }

    public DateOnly? CustomerSampleRequestDt { get; set; }

    public string? SampleRefNo { get; set; }

    public DateOnly? ProcessDt { get; set; }

    public DateOnly? RecevedDate { get; set; }

    public DateOnly? SampleExMillDate { get; set; }

    public int? SamplesQuantity { get; set; }

    public string? Remark { get; set; }

    public DateOnly? Issue { get; set; }

    public DateOnly? ReadyDate { get; set; }

    public string? Status { get; set; }

    public DateOnly? UnderDyeingDate { get; set; }

    public DateOnly? UnderYarnOpeningDate { get; set; }

    public DateOnly? PreLoomDate { get; set; }

    public DateOnly? OnLoomDate { get; set; }

    public DateOnly? FinishingDate { get; set; }

    public DateOnly? HoldDate { get; set; }

    public DateOnly? LatexDate { get; set; }

    public DateTime? DispStatuseDate { get; set; }

    public string? DispRemark { get; set; }

    public DateOnly? CancelDate { get; set; }

    public string? CancelRemark { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdatedBy { get; set; }

    public int? SampleNo { get; set; }

    public DateOnly? Etd { get; set; }

    public DateOnly? CsreqDate { get; set; }

    public bool IsSelected { get; set; }

    public DateOnly? RedyingDate { get; set; }

    public DateOnly? ReadyInspectionDate { get; set; }

    public DateOnly? SendUnit1Date { get; set; }

    public DateOnly? SampleEtd { get; set; }

    public string? DispatchBy { get; set; }
}
