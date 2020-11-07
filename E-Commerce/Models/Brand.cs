using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A brand name is required")]
        [StringLength(160)]
        public string BrandName { get; set; }

        //public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

        //public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
