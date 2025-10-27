using Rova.Shared.Models;

namespace Rova.Core.Interfaces
{
    public interface IReportingService
    {
        IEnumerable<ReportDto> GetDailyReports();
        IEnumerable<ReportDto> GetWeeklyReports();
        IEnumerable<AttendanceReportDto> GetAttendanceReports();
        PerformanceReportDto GetPerformanceReport();
    }
}