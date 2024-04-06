using backend.Models;
using HackItAll_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class DatabaseContext: DbContext
{
    public DbSet<Model> Models { get; set; }

    public DbSet<Battery> Batteries { get; set; }

    public DbSet<Car> Cars { get; set; }

    public DbSet<Station> Stations { get; set; }

    public DbSet<Reservation> Reservations { get; set; }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Station has Batteries
        modelBuilder.Entity<Station>()
            .HasMany(x => x.batteries)
            .WithOne(x => x.station)
            .HasForeignKey(x => x.stationId);

        // Battery has Model
        modelBuilder.Entity<Battery>()
            .HasOne(x => x.model)
            .WithMany(x => x.batteries)
            .HasForeignKey(x => x.modelId);

        // Car has Model
        modelBuilder.Entity<Car>()
            .HasOne(x => x.batteryModel)
            .WithMany(x => x.cars)
            .HasForeignKey(x => x.batteryModelId);


        // Reservation has Battery
        modelBuilder.Entity<Reservation>()
            .HasOne(x => x.battery)
            .WithOne(x => x.reservation)
            .HasForeignKey<Battery>(x => x.reservationId)
            .IsRequired(false);
            
    }
}