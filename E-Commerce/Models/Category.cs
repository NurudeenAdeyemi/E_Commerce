using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A category name is required")]
        [StringLength(160)]
        public string CategoryName { get; set; }

        public virtual ICollection<CategorySubCategory> CategorySubCategories { get; set; } = new List<CategorySubCategory>();

    }
}
