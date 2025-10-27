using Rova.Core.Interfaces;
using Rova.Shared.Models;

namespace Rova.Core.Services;

public class BookingService : IBookingService
{
    private readonly List<BookingDto> _bookings = new();

    public Task<BookingDto> CreateBookingAsync(BookingDto booking)
    {
        _bookings.Add(booking);
        return Task.FromResult(booking);
    }

    public Task<IEnumerable<BookingDto>> GetBookingsAsync()
    {
        return Task.FromResult<IEnumerable<BookingDto>>(_bookings);
    }

    public Task<BookingDto> GetBookingByIdAsync(Guid bookingId)
    {
        var booking = _bookings.FirstOrDefault(b => b.Id == bookingId);
        return Task.FromResult(booking!);
    }

    public Task<bool> UpdateBookingAsync(BookingDto booking)
    {
        var existing = _bookings.FirstOrDefault(b => b.Id == booking.Id);
        if (existing != null)
        {
            _bookings.Remove(existing);
            _bookings.Add(booking);
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }

    public Task<bool> DeleteBookingAsync(Guid bookingId)
    {
        var booking = _bookings.FirstOrDefault(b => b.Id == bookingId);
        if (booking != null)
        {
            _bookings.Remove(booking);
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }
}
