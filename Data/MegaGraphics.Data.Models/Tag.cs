namespace MegaGraphics.Data.Models
{
    using System.Collections.Generic;

    using MegaGraphics.Data.Common.Models;

    public class Tag : BaseDeletableModel<int>
    {
        public Tag()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
