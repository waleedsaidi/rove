using System;

namespace Rova.Mobile.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public TimeSpan EstimatedTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}