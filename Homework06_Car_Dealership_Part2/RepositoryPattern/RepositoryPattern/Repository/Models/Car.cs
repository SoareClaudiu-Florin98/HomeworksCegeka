using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    [Table("CAR")]
    [Index(nameof(FkBrandId), Name = "UQ__CAR__82BC07F869A71844", IsUnique = true)]
    public partial class Car
    {
        public Car()
        {
            OrderCars = new HashSet<OrderCar>();
        }

        [Key]
        [Column("Car_Id")]
        public int CarId { get; set; }
        [Column("Manufacturing_Date", TypeName = "date")]
        public DateTime? ManufacturingDate { get; set; }
        [Column("Fk_Brand_id")]
        public int? FkBrandId { get; set; }

        [ForeignKey(nameof(FkBrandId))]
        [InverseProperty(nameof(Brand.Car))]
        public virtual Brand FkBrand { get; set; }
        [InverseProperty(nameof(OrderCar.FkCar))]
        public virtual ICollection<OrderCar> OrderCars { get; set; }
    }
}
