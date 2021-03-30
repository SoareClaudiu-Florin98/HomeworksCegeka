using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    [Table("ActualCar_Features")]
    public partial class ActualCarFeature
    {
        [Key]
        [Column("ActualCar_Features_Id")]
        public int ActualCarFeaturesId { get; set; }
        [StringLength(20)]
        public string Feauture { get; set; }
        [Column("Fk_Model_id")]
        public int? FkModelId { get; set; }

        [ForeignKey(nameof(FkModelId))]
        [InverseProperty(nameof(Model.ActualCarFeatures))]
        public virtual Model FkModel { get; set; }
    }
}
