using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    [Table("CUSTOMER")]
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("Customer_Id")]
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Column("First_Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("Last_Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [InverseProperty(nameof(Order.FkCustomer))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
