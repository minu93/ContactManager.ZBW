using ContactManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ContactManager.Infrastructure.Persistence;

public sealed class ContactManagerDbContext : DbContext
{
    public ContactManagerDbContext(DbContextOptions<ContactManagerDbContext> options) : base(options) { }

    public DbSet<Person> People => Set<Person>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Trainee> Trainees => Set<Trainee>();
    public DbSet<CustomerNote> CustomerNotes => Set<CustomerNote>();

    public DbSet<ContactChange> ContactChanges => Set<ContactChange>();

    public DbSet<User> Users => Set<User>();


    protected override void OnModelCreating(ModelBuilder b)
    {

        b.Entity<Person>(eb =>
        {
            eb.ToTable("People");                 
            eb.HasKey(p => p.Id);
            eb.Property(p => p.Id).ValueGeneratedNever();
            eb.HasDiscriminator<string>("Discriminator")
              .HasValue<Person>("Person")
              .HasValue<Customer>("Customer")
              .HasValue<Employee>("Employee")
              .HasValue<Trainee>("Trainee");

            eb.Property(p => p.FirstName).IsRequired();
            eb.Property(p => p.LastName).IsRequired();
            eb.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth");
            eb.Property(p => p.Gender).HasColumnName("Gender");       
            eb.Property(p => p.Status).HasColumnName("Status");       
            eb.Property(p => p.ZipCode).HasColumnName("ZipCode");
        });


        b.Entity<Customer>(eb =>
        {
            eb.Property(c => c.CompanyName).HasColumnName("CompanyName");
            eb.Property(c => c.CompanyContact).HasColumnName("CompanyContact");
            eb.Property(c => c.CustomerType)
              .HasConversion<string>()
              .HasMaxLength(1)
              .HasColumnName("CustomerType");
        });

        b.Entity<CustomerNote>(eb =>
        {
            eb.ToTable("ContactNotes");
            eb.Property<Guid>("Id").ValueGeneratedOnAdd();
            eb.HasKey("Id");

            eb.Property(n => n.Note).IsRequired();
            eb.Property(n => n.CreatedAt);

            eb.HasOne(n => n.Customer)
              .WithMany()
              .HasForeignKey("ContactId")
              .OnDelete(DeleteBehavior.Cascade);

        });

        b.Entity<Employee>(eb =>
        {
            eb.Property(e => e.EmployeeNumber).HasColumnName("EmployeeNumber");
            eb.Property(e => e.Department).HasColumnName("Department");
            eb.Property(e => e.StartDate).HasColumnName("StartDate");
            eb.Property(e => e.EndDate).HasColumnName("EndDate");
            eb.Property(e => e.Employment).HasColumnName("Employment");
            eb.Property(e => e.Role).HasColumnName("Role");
            eb.Property(e => e.CadreLevel).HasColumnName("CadreLevel");
        });

        b.Entity<Trainee>(eb =>
        {
            eb.Property(t => t.TraineeYears).HasColumnName("TraineeYears");
            eb.Property(t => t.ActualTraineeYear).HasColumnName("ActualTraineeYear");
        });

        b.Entity<CustomerNote>(eb =>
        {
            eb.ToTable("CustomerNotes");
            eb.HasKey(n => n.Id);
            eb.Property(n => n.Id).ValueGeneratedNever();

            eb.Property(n => n.CreatedAt);
            eb.Property(n => n.Note).IsRequired();

            eb.HasOne(n => n.Customer)
              .WithMany()                        
              .HasForeignKey(n => n.CustomerId)   
              .OnDelete(DeleteBehavior.Cascade);

            eb.HasIndex(n => n.CustomerId);
            eb.HasIndex(n => new { n.CustomerId, n.CreatedAt });

        });

        b.Entity<ContactChange>(eb =>
        {
            eb.ToTable("ContactChanges");
            eb.HasKey(x => x.Id);
            eb.Property(x => x.PersonType).HasMaxLength(32);
            eb.Property(x => x.Action).HasConversion<string>().HasMaxLength(16);
            eb.Property(x => x.Summary);
            eb.Property(x => x.DataJson);
            eb.HasIndex(x => x.PersonId);
        });

        b.Entity<User>(eb =>
        {
            eb.ToTable("Users");
            eb.HasKey(u => u.Id);
            eb.Property(u => u.UserName).IsRequired().HasMaxLength(64);
            eb.HasIndex(u => u.UserName).IsUnique();
            eb.Property(u => u.PasswordHash).IsRequired();
            eb.Property(u => u.IsActive).HasDefaultValue(true);
        });
    }
}
