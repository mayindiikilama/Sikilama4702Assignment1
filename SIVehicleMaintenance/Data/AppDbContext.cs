using Microsoft.EntityFrameworkCore;
using SIVehicleMaintenance.Models;

namespace SIVehicleMaintenance.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
    }
}

