using System.Collections.ObjectModel;
using System.Windows.Input;
using Rova.Mobile.Models;
using Rova.Mobile.Services;

namespace Rova.Mobile.ViewModels
{
    public class MerchantDashboardViewModel : BaseViewModel
    {
        private readonly IReportingService _reportingService;
        private ObservableCollection<ReportDto> _attendanceReports;
        private ObservableCollection<PerformanceDto> _performanceData;

        public MerchantDashboardViewModel(IReportingService reportingService)
        {
            _reportingService = reportingService;
            LoadReportsCommand = new Command(async () => await LoadReports());
            LoadReports();
        }

        public ObservableCollection<ReportDto> AttendanceReports
        {
            get => _attendanceReports;
            set => SetProperty(ref _attendanceReports, value);
        }

        public ObservableCollection<PerformanceDto> PerformanceData
        {
            get => _performanceData;
            set => SetProperty(ref _performanceData, value);
        }

        public ICommand LoadReportsCommand { get; }

        private async Task LoadReports()
        {
            var attendanceReports = await _reportingService.GetAttendanceReportsAsync();
            var performanceData = await _reportingService.GetPerformanceDataAsync();

            AttendanceReports = new ObservableCollection<ReportDto>(attendanceReports);
            PerformanceData = new ObservableCollection<PerformanceDto>(performanceData);
        }
    }
}