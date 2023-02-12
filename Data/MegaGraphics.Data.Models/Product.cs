namespace MegaGraphics.Data.Models
{
    using System.Collections.Generic;

    using MegaGraphics.Data.Common.Models;

    public class Product : BaseDeletableModel<int>
    {
        public Product()
        {
            this.Categorys = new HashSet<Category>();
            this.Images = new HashSet<Image>();
            this.Tags = new HashSet<Tag>();
        }

        public string Name { get; set; }

        public string NameEnglish { get; set; }

        public string Description { get; set; }

        public string DescriptionEnglish { get; set; }

        public virtual ICollection<Category> Categorys { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
