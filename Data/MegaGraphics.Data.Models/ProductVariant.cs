namespace MegaGraphics.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ProductVariant
    {

        public int Size { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public decimal Price { get; set; }

        public int SizeHeight { get; set; }

        public int SizeWidth { get; set; }

    }
}
