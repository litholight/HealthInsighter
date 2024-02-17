using HealthInsighter.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthInsighter.Data
{
    public class HealthInsighterDbContext : DbContext
    {
        public HealthInsighterDbContext(DbContextOptions<HealthInsighterDbContext> options)
            : base(options) { }

        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<HealthEventType> HealthEventTypes { get; set; }
        public DbSet<HealthEvent> HealthEvents { get; set; }
        public DbSet<MeasurementType> MeasurementTypes { get; set; }
        public DbSet<BloodSample> BloodSamples { get; set; }
        public DbSet<AnalysisResult> AnalysisResults { get; set; }

        // Additional configurations can go here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring the HealthRecord entity
            modelBuilder.Entity<HealthRecord>(entity =>
            {
                entity.HasKey(e => e.HealthRecordId); // Primary Key
                entity
                    .Property(e => e.Timestamp)
                    .HasColumnType("timestamp without time zone") // For PostgreSQL compatibility
                    .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value
                entity.HasIndex(e => e.Timestamp); // Index for faster queries on Timestamp
            });

            // Configuring the HealthEventType entity
            modelBuilder.Entity<HealthEventType>(entity =>
            {
                entity.HasKey(e => e.EventTypeId); // Primary Key
            });

            // Configuring the HealthEvent entity and its relationship to HealthEventType
            modelBuilder.Entity<HealthEvent>(entity =>
            {
                entity.HasKey(e => e.HealthEventId); // Primary Key
                entity
                    .HasOne<HealthEventType>() // Assuming a HealthEvent has one HealthEventType
                    .WithMany() // Assuming a HealthEventType can have many HealthEvents
                    .HasForeignKey(e => e.EventTypeId); // ForeignKey in HealthEvent pointing to HealthEventType
            });

            // Configuring the MeasurementType entity
            modelBuilder.Entity<MeasurementType>(entity =>
            {
                entity.HasKey(e => e.MeasurementTypeId); // Primary Key
            });

            // Configuring the BloodSample entity
            modelBuilder.Entity<BloodSample>(entity =>
            {
                entity.HasKey(e => e.BloodSampleId); // Primary Key
                entity.Property(e => e.Timestamp).HasColumnType("timestamp without time zone"); // For PostgreSQL compatibility
                entity.Property(e => e.Metrics).HasColumnType("jsonb"); // Storing metrics as JSONB for flexibility and performance
            });

            // Configuring the AnalysisResult entity more explicitly
            modelBuilder.Entity<AnalysisResult>(entity =>
            {
                entity.HasKey(e => e.AnalysisResultId); // Primary Key

                // Explicitly define the relationship to HealthRecord
                entity
                    .HasOne(ar => ar.HealthRecord)
                    .WithMany() // Optionally specify the navigation property if it exists
                    .HasForeignKey(ar => ar.HealthRecordId)
                    .IsRequired(false) // Marking the foreign key as optional
                    .OnDelete(DeleteBehavior.SetNull); // Handling on delete

                // Explicitly define the relationship to HealthEvent
                entity
                    .HasOne(ar => ar.HealthEvent)
                    .WithMany() // Optionally specify the navigation property if it exists
                    .HasForeignKey(ar => ar.HealthEventId)
                    .IsRequired(false) // Marking the foreign key as optional
                    .OnDelete(DeleteBehavior.SetNull); // Handling on delete
            });

            // Ensure all configurations are correctly applied
            base.OnModelCreating(modelBuilder);
        }
    }
}
