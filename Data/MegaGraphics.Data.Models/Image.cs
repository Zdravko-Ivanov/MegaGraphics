namespace MegaGraphics.Data.Models
{
    using MegaGraphics.Data.Common.Models;

    public class Image : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
