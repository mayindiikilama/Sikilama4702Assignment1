using System.ComponentModel.DataAnnotations;

namespace SIVehicleMaintenance.Models
{
    public class MaintenanceRecord
    {
        public int Id { get; set; }

        [Required]
        public string VehicleName { get; set; } = string.Empty;

        [Required]
        public string ServiceType { get; set; } = string.Empty;

        [Range(0, 10000)]
        public decimal Cost { get; set; }

        public DateTime ServiceDate { get; set; }
    }
}
