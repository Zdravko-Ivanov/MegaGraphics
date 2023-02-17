namespace MegaGraphics.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MegaGraphics.Data.Common.Repositories;
    using MegaGraphics.Data.Models;
    using MegaGraphics.Services.Mapping;
    using MegaGraphics.Web.ViewModels.Product;

    public class CategoryService : ICategoryService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;

        public CategoryService(IDeletableEntityRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Task AddCategoryAsync(CategoryViewModel input)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> ShowAll<T>()
        {
            return this.categoryRepository.AllAsNoTracking().To<T>().ToList();
        }
    }
}
