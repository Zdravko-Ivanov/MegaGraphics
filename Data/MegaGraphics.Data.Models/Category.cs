namespace MegaGraphics.Data.Models
{
    using System.Collections.Generic;

    using MegaGraphics.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Childrens = new HashSet<Category>();
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public string NameEnglish { get; set; }

        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Category> Childrens { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
