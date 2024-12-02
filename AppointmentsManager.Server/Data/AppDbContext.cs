using AppointmentsManager.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentsManager.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
        public DbSet<Appointment> Appointments { get; set; }
    }
}
