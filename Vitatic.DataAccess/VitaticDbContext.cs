using Microsoft.EntityFrameworkCore;
using Vitatic.Entities;

namespace Vitatic.DataAccess;

public class VitaticDbContext: DbContext
{
    public VitaticDbContext()
    {

    }
    public VitaticDbContext(DbContextOptions<VitaticDbContext>options):base(options)
    {   
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Interface> Interfaces { get; set; }
    public DbSet<Activity> Activities{ get; set; }
    public DbSet<Category> Categories{ get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<Progress> Progresses { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Notification> Notifications  { get; set; }
    public DbSet<Instruction> Instructions { get; set; }
    public DbSet<AdviceSection> AdviceSections { get; set; }
    public DbSet<Advice> Advices { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Interface>()
            .HasOne(b => b.AdviceSection)
            .WithOne(i => i.Interface)
            .HasForeignKey<AdviceSection>(b => b.Id);
        modelBuilder.Entity<Interface>()
            .HasOne(b => b.Instruction)
            .WithOne(i => i.Interface)
            .HasForeignKey<Instruction>(b => b.Id);

        modelBuilder.Entity<Interface>()
            .HasOne(b => b.Schedule)
            .WithOne(i => i.Interface)
            .HasForeignKey<Schedule>(b => b.Id);
        modelBuilder.Entity<Interface>()
            .HasOne(b => b.User)
            .WithOne(i => i.Interface)
            .HasForeignKey<User>(b => b.Id);
    }

}