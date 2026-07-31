using System;
using System.Collections.Generic;

namespace Inspection_Outcome.Models;

public partial class TblItuserSystemInfo
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public int? SystemSrNo { get; set; }

    public string? ItemName { get; set; }

    public string? DepartmentName { get; set; }

    public string? CompanyName { get; set; }

    public string? Category { get; set; }

    public string? ScreenSize { get; set; }

    public string? Cpu { get; set; }

    public string? MotherBoard { get; set; }

    public string? Ram { get; set; }

    public string? HardDisk { get; set; }

    public string? DataDriveUsb { get; set; }

    public string? Dvdcombo { get; set; }

    public string? DisplayCard { get; set; }

    public string? SoundCard { get; set; }

    public string? LanCard { get; set; }

    public string? KeyBoard { get; set; }

    public string? Mouse { get; set; }

    public string? Speaker { get; set; }

    public string? Monitor { get; set; }

    public string? ModelNo { get; set; }

    public DateTime? Warranty { get; set; }

    public string? Cabinet { get; set; }

    public string? SystemStatus { get; set; }

    public string? WarrantyAmc { get; set; }

    public string? OperatingSystem { get; set; }

    public string? Antivirus { get; set; }

    public string? Remark { get; set; }

    public int? UserId { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Other { get; set; }

    public string? Ups { get; set; }

    public string? PrinterScanner { get; set; }

    public string? PrinterScannerSrNo { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? MonitorSrNo { get; set; }

    public DateTime? MonitorWarranty { get; set; }
}
