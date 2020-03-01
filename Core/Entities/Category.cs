using NetSmartz.Infrastructure.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetSmartz.Infrastructure.Entities
{
    public class Category:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceRange { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
