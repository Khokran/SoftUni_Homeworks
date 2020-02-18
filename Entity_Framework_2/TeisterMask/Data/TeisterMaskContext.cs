namespace TeisterMask.Data
{
    using Microsoft.EntityFrameworkCore;
    using TeisterMask.Data.Models;

    public class TeisterMaskContext : DbContext
    {
        public TeisterMaskContext() { }

        public TeisterMaskContext(DbContextOptions options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Username)
                      .HasMaxLength(40)
                      .IsRequired(true)
                      .IsUnicode(true);

                entity.Property(e => e.Email)
                      .HasMaxLength(100)
                      .IsRequired(true)
                      .IsUnicode(true);

                entity.Property(e => e.Phone)
                      .HasMaxLength(100)
                      .IsRequired(true)
                      .IsUnicode(false);
            });
            modelBuilder.Entity<EmployeeTask>(entity =>
            {
                entity.HasKey(et => et.EmployeeId);

                entity.HasOne(et => et.Employee)
                      .WithMany(e => e.EmployeesTasks)
                      .HasForeignKey(et => et.EmployeeId);

                entity.HasOne(et => et.Task)
                      .WithMany(t => t.EmployeesTasks)
                      .HasForeignKey(et => et.TaskId);
            });
            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Name)
                      .HasMaxLength(40)
                      .IsRequired(true)
                      .IsUnicode(true);

                entity.Property(p => p.OpenDate)
                      .IsRequired(true)
                      .HasColumnName("DATETIME2")
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(p => p.DueDate)
                      .IsRequired(true)
                      .HasColumnName("DATETIME2")
                      .HasDefaultValueSql("GETDATE()");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Name)
                      .HasMaxLength(40)
                      .IsRequired(true)
                      .IsUnicode(true);

                entity.Property(t => t.OpenDate)
                      .IsRequired(true)
                      .HasColumnName("DATETIME2")
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(t => t.DueDate)
                      .IsRequired(true)
                      .HasColumnName("DATETIME2")
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(t => t.ExecutionType)
                      .IsRequired(true)
                      .HasDefaultValue();

                entity.Property(t => t.LabelType)
                      .IsRequired(true)
                      .HasDefaultValue();

                entity.HasOne(t => t.Project)
                      .WithMany(p => p.Tasks)
                      .HasForeignKey(t => t.ProjectId);
            });
        }
    }
}