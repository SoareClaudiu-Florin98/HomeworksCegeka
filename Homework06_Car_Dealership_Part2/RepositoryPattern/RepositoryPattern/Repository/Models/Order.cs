using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    [Table("ORDERS")]
    public partial class Order
    {
        public Order()
        {
            OrderCars = new HashSet<OrderCar>();
        }

        [Key]
        [Column("Order_Id")]
        public int OrderId { get; set; }
        [Column("Fk_Customer_Id")]
        public int? FkCustomerId { get; set; }

        [ForeignKey(nameof(FkCustomerId))]
        [InverseProperty(nameof(Customer.Orders))]
        public virtual Customer FkCustomer { get; set; }
        [InverseProperty(nameof(OrderCar.FkOrder))]
        public virtual ICollection<OrderCar> OrderCars { get; set; }
    }
}
