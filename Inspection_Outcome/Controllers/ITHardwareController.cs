using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
namespace Inspection_Outcome.Controllers
{
    public class ITHardwareController : Controller
    {
        private readonly ErpDataContext _dbcontext;

        public ITHardwareController(ErpDataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult IndexITHardware(string username, string systemSrNo)
        {
            var query =
                from m in _dbcontext.TblIthardwareMsts
                join d in _dbcontext.TblItuserSystemInfos
                    on m.SystemSrNo equals d.SystemSrNo
                join n in _dbcontext.TblNetworkInfoMsts
                    on d.UserName equals n.ComputerName
                select new
                {
                    m.SystemSrNo,
                    m.DepartmentName,
                    d.UserName,
                    d.Cpu,
                    d.MotherBoard,
                    d.Ram,
                    d.HardDisk,
                    d.DataDriveUsb,
                    d.Dvdcombo,
                    d.DisplayCard,
                    d.Mouse,
                    d.SoundCard,
                    d.KeyBoard,
                    d.LanCard,
                    d.Speaker,
                    d.Monitor,
                    d.MonitorSrNo,
                    d.Cabinet,
                    d.SystemStatus,
                    d.WarrantyAmc,
                    d.OperatingSystem,
                    d.Antivirus,
                    d.PrinterScanner,
                    d.PrinterScannerSrNo,
                    d.Ups,
                    n.ComputerName,
                    n.UserLoginName,
                    n.Password,
                    n.UserRight,
                    n.Ipaddress,
                    n.SubnetMask,
                    n.Gateway,
                    n.PreferredDns,
                    n.AlternetDns,
                    n.InternetAccess,
                    n.EmailClient
                };

            var data = query.ToList();

            if (!string.IsNullOrEmpty(username))
                data = data.Where(x => x.UserName == username).ToList();

            if (!string.IsNullOrEmpty(systemSrNo))
                data = data.Where(x => x.SystemSrNo.ToString() == systemSrNo).ToList();

            return View(data);
        }
        private List<dynamic> GetHardwareData()
        {
            return (from m in _dbcontext.TblIthardwareMsts
                    join d in _dbcontext.TblItuserSystemInfos
                        on m.SystemSrNo equals d.SystemSrNo
                    join n in _dbcontext.TblNetworkInfoMsts
                        on d.UserName equals n.ComputerName
                    select new
                    {
                        m.SystemSrNo,
                        m.DepartmentName,
                        d.UserName,
                        d.Cpu,
                        d.MotherBoard,
                        d.Ram,
                        d.HardDisk,
                        d.DataDriveUsb,
                        d.Dvdcombo,
                        d.DisplayCard,
                        d.Mouse,
                        d.SoundCard,
                        d.KeyBoard,
                        d.LanCard,
                        d.Speaker,
                        d.Monitor,
                        d.MonitorSrNo,
                        d.Cabinet,
                        d.SystemStatus,
                        d.WarrantyAmc,
                        d.OperatingSystem,
                        d.Antivirus,
                        d.PrinterScanner,
                        d.PrinterScannerSrNo,
                        d.Ups,
                        n.ComputerName,
                        n.UserLoginName,
                        n.Password,
                        n.UserRight,
                        n.Ipaddress,
                        n.SubnetMask,
                        n.Gateway,
                        n.PreferredDns,
                        n.AlternetDns,
                        n.InternetAccess,
                        n.EmailClient
                    }).ToList<dynamic>();
        }

        [HttpPost]
        public IActionResult PrintSelected(List<string> selectedSystems)
        {
            var data = GetHardwareData()
                .Where(x => selectedSystems.Contains(x.SystemSrNo.ToString()))
                .ToList();

            return View("PrintPage", data);
        }

        [HttpPost]
        public IActionResult ExportPDF(List<string> selectedSystems)
        {
            var data = GetHardwareData()
                .Where(x => selectedSystems.Contains(x.SystemSrNo.ToString()))
                .ToList();

            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(20);

                    page.Content().Column(col =>
                    {
                        foreach (var r in data)
                        {
                            col.Item().Text("IT HARDWARE ASSET SHEET")
                                .Bold().FontSize(16).AlignCenter();

                            void Section(string title)
                            {
                                col.Item().Background(Colors.Grey.Lighten2)
                                    .Padding(5)
                                    .Text(title).Bold();
                            }

                            void Row(string l1, object v1, string l2, object v2)
                            {
                                col.Item().Table(t =>
                                {
                                    t.ColumnsDefinition(c =>
                                    {
                                        c.RelativeColumn();
                                        c.RelativeColumn();
                                        c.RelativeColumn();
                                        c.RelativeColumn();
                                    });

                                    t.Cell().Border(1).Padding(3).Text(l1).Bold();
                                    t.Cell().Border(1).Padding(3).Text(v1?.ToString());

                                    t.Cell().Border(1).Padding(3).Text(l2).Bold();
                                    t.Cell().Border(1).Padding(3).Text(v2?.ToString());
                                });
                            }

                            // SYSTEM DETAILS
                            Section("System Details");

                            Row("System SrNo", r.SystemSrNo,
                                "Department", r.DepartmentName);

                            Row("User Name", r.UserName,
                                "System Status", r.SystemStatus);

                            Row("Warranty/AMC", r.WarrantyAmc,
                                "Operating System", r.OperatingSystem);

                            Row("Antivirus", r.Antivirus, "", "");

                            // HARDWARE CONFIGURATION
                            Section("Hardware Configuration");

                            Row("CPU", r.Cpu, "MotherBoard", r.MotherBoard);
                            Row("RAM", r.Ram, "HardDisk", r.HardDisk);
                            Row("Data Drive USB", r.DataDriveUsb, "DVD Combo", r.Dvdcombo);
                            Row("Display Card", r.DisplayCard, "Cabinet", r.Cabinet);
                            Row("Keyboard", r.KeyBoard, "Mouse", r.Mouse);
                            Row("LAN Card", r.LanCard, "Sound Card", r.SoundCard);
                            Row("Speaker", r.Speaker, "Monitor", r.Monitor);
                            Row("Monitor SrNo", r.MonitorSrNo, "UPS", r.Ups);

                            Row("Printer Scanner", r.PrinterScanner,
                                "Printer SrNo", r.PrinterScannerSrNo);

                            // NETWORK CONFIGURATION
                            Section("Network Configuration");

                            Row("Computer Name", r.ComputerName,
                                "User Login Name", r.UserLoginName);

                            Row("User Right", r.UserRight,
                                "IP Address", r.Ipaddress);

                            Row("Subnet Mask", r.SubnetMask,
                                "Gateway", r.Gateway);

                            Row("Preferred DNS", r.PreferredDns,
                                "Alternate DNS", r.AlternetDns);

                            Row("Internet Access", r.InternetAccess,
                                "Email Client", r.EmailClient);
                            if (r != data.Last())
                                col.Item().PageBreak();

                        }
                    });
                });
            }).GeneratePdf();

            return File(pdf, "application/pdf", "AssetSheet.pdf");
        }

        [HttpPost]
        public IActionResult ExportExcel(List<string> selectedSystems)
        {
            ExcelPackage.License.SetNonCommercialOrganization("Inspection Outcome");

            var data = GetHardwareData()
                .Where(x => selectedSystems.Contains(x.SystemSrNo.ToString()))
                .ToList();

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("Asset Sheet");

                int row = 1;

            foreach (var r in data)
            {
                // Title
                ws.Cells[row, 1, row, 2].Merge = true;
                ws.Cells[row, 1].Value = "IT HARDWARE ASSET SHEET";
                ws.Cells[row, 1].Style.Font.Bold = true;
                ws.Cells[row, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                row += 2;

                void AddRow(string label, string value)
                {
                    ws.Cells[row, 1].Value = label;
                    ws.Cells[row, 2].Value = value;

                    ws.Cells[row, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[row, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                    ws.Cells[row, 1].Style.Font.Bold = true;

                    ws.Cells[row, 1, row, 2].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                    row++;
                }

                AddRow("SYS S/N", r.SystemSrNo.ToString());
                AddRow("DEPT NAME", r.DepartmentName);
                AddRow("USER NAME", r.UserName);
                AddRow("CPU", r.Cpu);
                AddRow("MOTHERBOARD", r.MotherBoard);
                AddRow("RAM", r.Ram);
                AddRow("HARDDISK", r.HardDisk);
                AddRow("USB DRIVE", r.DataDriveUsb);
                AddRow("DVD DRIVE", r.Dvdcombo);
                AddRow("DISPLAY CARD", r.DisplayCard);
                AddRow("SOUND CARD", r.SoundCard);
                AddRow("MOUSE", r.Mouse);
                AddRow("KEYBOARD", r.KeyBoard);
                AddRow("LAN CARD", r.LanCard);
                AddRow("SPEAKERS", r.Speaker);
                AddRow("MONITOR", r.Monitor);
                AddRow("MONITOR S/N", r.MonitorSrNo);
                AddRow("CABINET", r.Cabinet);
                AddRow("SYSTEM STATUS", r.SystemStatus);
                AddRow("WARRANTY", r.WarrantyAmc);
                AddRow("OPERATING SYSTEM", r.OperatingSystem);
                AddRow("ANTIVIRUS", r.Antivirus);

                AddRow("COMPUTER NAME", r.ComputerName);
                AddRow("USER LOGIN", r.UserLoginName);
                AddRow("IP ADDRESS", r.Ipaddress);
                AddRow("SUBNET MASK", r.SubnetMask);
                AddRow("GATEWAY", r.Gateway);
                AddRow("PREFERRED DNS", r.PreferredDns);
                AddRow("ALTERNATE DNS", r.AlternetDns);
                AddRow("INTERNET ACCESS", r.InternetAccess);
                AddRow("EMAIL CLIENT", r.EmailClient);

                row += 2; // gap between assets
            }

            ws.Column(1).Width = 30;
            ws.Column(2).Width = 40;

            var file = package.GetAsByteArray();

            return File(file,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "AssetSheet.xlsx");
        }
    }

}
}
