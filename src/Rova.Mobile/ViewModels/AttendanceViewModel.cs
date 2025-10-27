using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Rova.Mobile.Models;
using Rova.Mobile.Services;
using Xamarin.Forms;

namespace Rova.Mobile.ViewModels
{
    public class AttendanceViewModel : BaseViewModel
    {
        private readonly IAttendanceService _attendanceService;
        private ObservableCollection<AttendanceRecord> _attendanceRecords;

        public ObservableCollection<AttendanceRecord> AttendanceRecords
        {
            get => _attendanceRecords;
            set => SetProperty(ref _attendanceRecords, value);
        }

        public ICommand LoadAttendanceCommand { get; }

        public AttendanceViewModel(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
            LoadAttendanceCommand = new Command(async () => await LoadAttendanceRecords());
            AttendanceRecords = new ObservableCollection<AttendanceRecord>();
        }

        private async Task LoadAttendanceRecords()
        {
            IsBusy = true;
            try
            {
                var records = await _attendanceService.GetAttendanceRecordsAsync();
                AttendanceRecords.Clear();
                foreach (var record in records)
                {
                    AttendanceRecords.Add(record);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., show a message to the user)
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}