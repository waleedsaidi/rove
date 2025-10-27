using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rova.Shared.Models;

namespace Rova.Mobile.Services
{
    public class AttendanceService
    {
        private readonly List<AttendanceRecord> _attendanceRecords;

        public AttendanceService()
        {
            _attendanceRecords = new List<AttendanceRecord>();
        }

        public Task<bool> RecordAttendance(string userId)
        {
            var record = new AttendanceRecord
            {
                UserId = userId,
                Timestamp = DateTime.UtcNow
            };

            _attendanceRecords.Add(record);
            return Task.FromResult(true);
        }

        public Task<List<AttendanceRecord>> GetAttendanceRecords(string userId)
        {
            var records = _attendanceRecords.FindAll(r => r.UserId == userId);
            return Task.FromResult(records);
        }
    }

    public class AttendanceRecord
    {
        public string UserId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}