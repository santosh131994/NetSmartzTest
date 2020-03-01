using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetSmartz.Application.Models
{
   public  class ProductModel
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        [Required]

        public decimal Price { get; set; }

        public decimal Discount { get; set; }
        public int? CategoryId { get; set; }
        public List<CategoryModel> CategoryList { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Message { get; set; }

    }
}
