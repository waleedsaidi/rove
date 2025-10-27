using System;

namespace Rova.Mobile.Models
{
    public class BookingModel
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan BookingTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string Status { get; set; } // e.g., Pending, Confirmed, Completed, Cancelled

        public BookingModel(int id, string serviceName, DateTime bookingDate, TimeSpan bookingTime, string customerName, string customerContact, string status)
        {
            Id = id;
            ServiceName = serviceName;
            BookingDate = bookingDate;
            BookingTime = bookingTime;
            CustomerName = customerName;
            CustomerContact = customerContact;
            Status = status;
        }
    }
}