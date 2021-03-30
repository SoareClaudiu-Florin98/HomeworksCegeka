using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RepositoryPattern.Repository.Models;

#nullable disable

namespace RepositoryPattern.Repository
{
    public partial class CarDealershipDbContext : DbContext
    {
        public CarDealershipDbContext()
        {
        }

        public CarDealershipDbContext(DbContextOptions<CarDealershipDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActualCarFeature> ActualCarFeatures { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderCar> OrderCars { get; set; }
        public virtual DbSet<PossibleFeature> PossibleFeatures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\soare\\source\\repos\\HomeworksCegeka\\Homework05_Car_Dealership_Part1\\CarDealership.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActualCarFeature>(entity =>
            {
                entity.HasKey(e => e.ActualCarFeaturesId)
                    .HasName("PK__ActualCa__43A8941D6E025793");

                entity.Property(e => e.Feauture).IsUnicode(false);

                entity.HasOne(d => d.FkModel)
                    .WithMany(p => p.ActualCarFeatures)
                    .HasForeignKey(d => d.FkModelId)
                    .HasConstraintName("FK__ActualCar__Fk_Mo__37A5467C");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandId).ValueGeneratedNever();

                entity.Property(e => e.BrandName).IsUnicode(false);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasOne(d => d.FkBrand)
                    .WithOne(p => p.Car)
                    .HasForeignKey<Car>(d => d.FkBrandId)
                    .HasConstraintName("FK__CAR__Fk_Brand_id__2B3F6F97");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(e => e.ModelId).ValueGeneratedNever();

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.HasOne(d => d.FkBrand)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.FkBrandId)
                    .HasConstraintName("FK__MODEL__Fk_Brand___31EC6D26");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.HasOne(d => d.FkCustomer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.FkCustomerId)
                    .HasConstraintName("FK__ORDERS__Fk_Custo__25869641");
            });

            modelBuilder.Entity<OrderCar>(entity =>
            {
                entity.Property(e => e.OrderCarId).ValueGeneratedNever();

                entity.HasOne(d => d.FkCar)
                    .WithMany(p => p.OrderCars)
                    .HasForeignKey(d => d.FkCarId)
                    .HasConstraintName("FK__ORDER_CAR__Fk_Ca__2F10007B");

                entity.HasOne(d => d.FkOrder)
                    .WithMany(p => p.OrderCars)
                    .HasForeignKey(d => d.FkOrderId)
                    .HasConstraintName("FK__ORDER_CAR__Fk_Or__2E1BDC42");
            });

            modelBuilder.Entity<PossibleFeature>(entity =>
            {
                entity.HasKey(e => e.PossibleFeautureId)
                    .HasName("PK__Possible__ACC80C16483B76FA");

                entity.Property(e => e.Feauture).IsUnicode(false);

                entity.HasOne(d => d.FkModel)
                    .WithMany(p => p.PossibleFeatures)
                    .HasForeignKey(d => d.FkModelId)
                    .HasConstraintName("FK__PossibleF__Fk_Mo__34C8D9D1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
