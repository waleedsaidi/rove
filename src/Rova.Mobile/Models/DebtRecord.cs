using System;

namespace Rova.Mobile.Models
{
    public class DebtRecord
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Notes { get; set; }
    }
}