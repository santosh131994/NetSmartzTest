using NetSmartz.Infrastructure.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetSmartz.Infrastructure.Entities
{
   public  class Product:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public  decimal Discount { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int CategoryId { get; set; }
    }
}
