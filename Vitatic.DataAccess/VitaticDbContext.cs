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
    public DbSet<Category> Categories{ get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
    public DbSet<Progress> Progresses { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Notification> Notifications  { get; set; }
    public DbSet<Instruccion> Instruccions { get; set; }
    public DbSet<AdviceSection> AdviceSections { get; set; }
    public DbSet<Advice> Advices { get; set; }













}