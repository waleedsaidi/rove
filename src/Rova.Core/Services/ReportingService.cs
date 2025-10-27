using Rova.Core.Interfaces;
using Rova.Shared.Models;

namespace Rova.Core.Services;

public class ReportingService : IReportingService
{
    public IEnumerable<ReportDto> GetDailyReports()
    {
        // TODO: Implement daily reports
        return new List<ReportDto>();
    }

    public IEnumerable<ReportDto> GetWeeklyReports()
    {
        // TODO: Implement weekly reports
        return new List<ReportDto>();
    }

    public IEnumerable<AttendanceReportDto> GetAttendanceReports()
    {
        // TODO: Implement attendance reports
        return new List<AttendanceReportDto>();
    }

    public PerformanceReportDto GetPerformanceReport()
    {
        // TODO: Implement performance report
        return new PerformanceReportDto();
    }
}
