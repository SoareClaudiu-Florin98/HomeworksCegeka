using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepositoryPattern.Repository.Models
{
    public partial class PossibleFeature
    {
        [Key]
        [Column("PossibleFeauture_Id")]
        public int PossibleFeautureId { get; set; }
        [StringLength(20)]
        public string Feauture { get; set; }
        [Column("Fk_Model_id")]
        public int? FkModelId { get; set; }

        [ForeignKey(nameof(FkModelId))]
        [InverseProperty(nameof(Model.PossibleFeatures))]
        public virtual Model FkModel { get; set; }
    }
}
