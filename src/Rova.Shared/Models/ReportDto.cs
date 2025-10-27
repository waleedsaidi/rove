using System;

namespace Rova.Shared.Models
{
    public class ReportDto
    {
        public DateTime ReportDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalServicesRendered { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalCustomers { get; set; }
        public string PerformanceSummary { get; set; }
    }
}