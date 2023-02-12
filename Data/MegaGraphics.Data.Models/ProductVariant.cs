namespace MegaGraphics.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ProductVariant
    {

        public int Id { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public decimal Price { get; set; }

        public int Size { get; set; }
    }
}
