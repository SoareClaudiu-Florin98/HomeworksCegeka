using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    [Table("MODEL")]
    public partial class Model
    {
        public Model()
        {
            ActualCarFeatures = new HashSet<ActualCarFeature>();
            PossibleFeatures = new HashSet<PossibleFeature>();
        }

        [Key]
        [Column("Model_Id")]
        public int ModelId { get; set; }
        [Column("Model_Name")]
        [StringLength(50)]
        public string ModelName { get; set; }
        [Column("Fk_Brand_id")]
        public int? FkBrandId { get; set; }
        public int? Price { get; set; }

        [ForeignKey(nameof(FkBrandId))]
        [InverseProperty(nameof(Brand.Models))]
        public virtual Brand FkBrand { get; set; }
        [InverseProperty(nameof(ActualCarFeature.FkModel))]
        public virtual ICollection<ActualCarFeature> ActualCarFeatures { get; set; }
        [InverseProperty(nameof(PossibleFeature.FkModel))]
        public virtual ICollection<PossibleFeature> PossibleFeatures { get; set; }
    }
}
