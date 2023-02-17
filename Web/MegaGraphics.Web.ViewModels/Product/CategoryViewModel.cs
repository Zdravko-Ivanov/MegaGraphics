namespace MegaGraphics.Web.ViewModels.Product
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MegaGraphics.Data.Models;
    using MegaGraphics.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public CategoryViewModel()
        {
            this.Categories = new HashSet<CategoryViewModel>();
        }

        public int CategoryId { get; set; }

        public int? ParentCategoryId { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        public string NameEnglish { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
