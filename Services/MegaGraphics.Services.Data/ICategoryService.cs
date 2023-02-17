namespace MegaGraphics.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MegaGraphics.Web.ViewModels.Product;

    public interface ICategoryService
    {
        Task AddCategoryAsync(CategoryViewModel input);

        IEnumerable<T> ShowAll<T>();
    }
}
