namespace Rova.Shared.Models;

public class PerformanceReportDto
{
    public int Id { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public double Score { get; set; }
    public string Comments { get; set; } = string.Empty;
}
