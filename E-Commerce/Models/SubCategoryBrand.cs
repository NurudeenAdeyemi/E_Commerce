using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class SubCategoryBrand
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public SubCategory SubCategory { get; set; }

        public Brand Brand { get; set; }
    }
}
