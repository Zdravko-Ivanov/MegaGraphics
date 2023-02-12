using MegaGraphics.Data.Models;
using System.Collections.Generic;

namespace MegaGraphics.Web.ViewModels.Home
{
    public class CreateProductInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal? PriceMedium { get; set; }

        public decimal? PriceLarge { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<Category> Categorys { get; set; }
    }
}
