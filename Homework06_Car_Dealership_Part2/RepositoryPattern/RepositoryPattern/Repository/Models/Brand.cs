using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    [Table("BRAND")]
    public partial class Brand
    {
        public Brand()
        {
            Models = new HashSet<Model>();
        }

        [Key]
        [Column("Brand_Id")]
        public int BrandId { get; set; }
        [Column("Brand_Name")]
        [StringLength(30)]
        public string BrandName { get; set; }

        [InverseProperty("FkBrand")]
        public virtual Car Car { get; set; }
        [InverseProperty(nameof(Model.FkBrand))]
        public virtual ICollection<Model> Models { get; set; }
    }
}
