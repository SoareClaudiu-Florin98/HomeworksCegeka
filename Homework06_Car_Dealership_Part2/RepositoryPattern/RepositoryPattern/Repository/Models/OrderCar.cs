using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    [Table("ORDER_CAR")]
    public partial class OrderCar
    {
        [Key]
        [Column("Order_Car_Id")]
        public int OrderCarId { get; set; }
        [Column("Fk_Order_Id")]
        public int? FkOrderId { get; set; }
        [Column("Fk_Car_Id")]
        public int? FkCarId { get; set; }
        [Column("Buy_Date", TypeName = "date")]
        public DateTime? BuyDate { get; set; }

        [ForeignKey(nameof(FkCarId))]
        [InverseProperty(nameof(Car.OrderCars))]
        public virtual Car FkCar { get; set; }
        [ForeignKey(nameof(FkOrderId))]
        [InverseProperty(nameof(Order.OrderCars))]
        public virtual Order FkOrder { get; set; }
    }
}
