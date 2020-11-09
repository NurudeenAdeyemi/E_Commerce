using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A brand name is required")]
        [StringLength(160)]
        public string SubCategoryName { get; set; }

        public virtual ICollection<CategorySubCategory> CategorySubCategories { get; set; } = new List<CategorySubCategory>();

        public virtual ICollection<SubCategoryBrand> SubCategoryBrands { get; set; } = new List<SubCategoryBrand>();
    }
}
