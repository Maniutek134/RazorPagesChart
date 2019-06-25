using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RazorPagesChart.Model
{
    public partial class DataBaseGdyniaContext : DbContext
    {
        public DataBaseGdyniaContext()
        {
        }

        public DataBaseGdyniaContext(DbContextOptions<DataBaseGdyniaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AverageIntensity> AverageIntensity { get; set; }
        public virtual DbSet<Intensity> Intensity { get; set; }
        public virtual DbSet<WeatherCondition> WeatherCondition { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=DataBaseGdynia;User=SA;Password=Zaq12345@!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AverageIntensity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("AverageIntensity_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageMeasurementTime)
                    .HasColumnName("averageMeasurementTime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Humidity).HasColumnName("humidity");

                entity.Property(e => e.Intensity).HasColumnName("intensity");

                entity.Property(e => e.Pressure).HasColumnName("pressure");

                entity.Property(e => e.RoadSegmentId).HasColumnName("roadSegmentId");

                entity.Property(e => e.Temperature).HasColumnName("temperature");

                entity.Property(e => e.Visibility).HasColumnName("visibility");

                entity.Property(e => e.WindDeg).HasColumnName("windDeg");

                entity.Property(e => e.WindSpeed).HasColumnName("windSpeed");
            });

            modelBuilder.Entity<Intensity>(entity =>
            {
                entity.HasIndex(e => e.DbTemperatureid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DbTemperatureid).HasColumnName("dbTemperatureid");

                entity.Property(e => e.Intenstiy).HasColumnName("intenstiy");

                entity.Property(e => e.MeasureTime).HasColumnName("measureTime");

                entity.Property(e => e.RoadSegmentId).HasColumnName("roadSegmentId");

                entity.HasOne(d => d.DbTemperature)
                    .WithMany(p => p.Intensity)
                    .HasForeignKey(d => d.DbTemperatureid);
            });

            modelBuilder.Entity<WeatherCondition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Humidity).HasColumnName("humidity");

                entity.Property(e => e.MeasureTime).HasColumnName("measureTime");

                entity.Property(e => e.Pressure).HasColumnName("pressure");

                entity.Property(e => e.Temperature).HasColumnName("temperature");

                entity.Property(e => e.Visibility).HasColumnName("visibility");

                entity.Property(e => e.WindDeg).HasColumnName("windDeg");

                entity.Property(e => e.WindSpeed).HasColumnName("windSpeed");
            });
        }
    }
}
