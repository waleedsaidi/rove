namespace Rova.Shared.Models;

public class AttendanceReportDto
{
    public int Id { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
}
