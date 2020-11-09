using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class CategorySubCategory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }

        public Category Category { get; set; }

        public SubCategory SubCategory { get; set; }
    }
}
