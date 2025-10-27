using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rova.Shared.Models;

namespace Rova.Mobile.Services
{
    public class BookingService
    {
        private readonly List<BookingModel> _bookings;

        public BookingService()
        {
            _bookings = new List<BookingModel>();
        }

        public Task<List<BookingModel>> GetBookingsAsync()
        {
            return Task.FromResult(_bookings);
        }

        public Task<BookingModel> GetBookingByIdAsync(int id)
        {
            var booking = _bookings.Find(b => b.Id == id);
            return Task.FromResult(booking);
        }

        public Task<bool> CreateBookingAsync(BookingModel booking)
        {
            _bookings.Add(booking);
            return Task.FromResult(true);
        }

        public Task<bool> UpdateBookingAsync(BookingModel booking)
        {
            var existingBooking = _bookings.Find(b => b.Id == booking.Id);
            if (existingBooking != null)
            {
                existingBooking.ServiceId = booking.ServiceId;
                existingBooking.Date = booking.Date;
                existingBooking.Time = booking.Time;
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<bool> DeleteBookingAsync(int id)
        {
            var booking = _bookings.Find(b => b.Id == id);
            if (booking != null)
            {
                _bookings.Remove(booking);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}