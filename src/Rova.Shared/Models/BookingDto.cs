using System;

namespace Rova.Shared.Models
{
    public class BookingDto
    {
        public Guid Id { get; set; }
        public int ServiceId { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan BookingTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string Status { get; set; } // e.g., Pending, Confirmed, Completed, Cancelled
    }
}