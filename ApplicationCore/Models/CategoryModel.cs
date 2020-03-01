using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetSmartz.Application.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? PriceRange { get; set; }
        public int? DisplayOrder { get; set; }
        public string Message { get; set; }

    }
}
