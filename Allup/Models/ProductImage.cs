using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Allup.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:255)]
        public string Image { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
