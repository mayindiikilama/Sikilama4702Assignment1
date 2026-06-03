using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIVehicleMaintenance.Data;
using SIVehicleMaintenance.Models;

namespace SIVehicleMaintenance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MaintenanceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MaintenanceRecord>>> GetAll()
        {
            return await _context.MaintenanceRecords.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MaintenanceRecord>> GetById(int id)
        {
            var record = await _context.MaintenanceRecords.FindAsync(id);

            if (record == null)
                return NotFound();

            return record;
        }

        [HttpPost]
        public async Task<ActionResult<MaintenanceRecord>> Create(MaintenanceRecord record)
        {
            _context.MaintenanceRecords.Add(record);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetById),
                new { id = record.Id },
                record);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MaintenanceRecord record)
        {
            if (id != record.Id)
                return BadRequest();

            _context.Entry(record).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var record = await _context.MaintenanceRecords.FindAsync(id);

            if (record == null)
                return NotFound();

            _context.MaintenanceRecords.Remove(record);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
