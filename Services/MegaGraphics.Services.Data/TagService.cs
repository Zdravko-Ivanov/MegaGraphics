namespace MegaGraphics.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MegaGraphics.Data.Common.Repositories;
    using MegaGraphics.Data.Models;
    using MegaGraphics.Services.Mapping;
    using MegaGraphics.Web.ViewModels.Product;

    public class TagService : ITagService
    {
        private readonly IDeletableEntityRepository<Tag> tagsRepository;

        public TagService(IDeletableEntityRepository<Tag> tagsRepository)
        {
            this.tagsRepository = tagsRepository;
        }

        public async Task AddTagAsync(TagViewModel input)
        {
            var tag = new Tag { Name = input.Name };
            await this.tagsRepository.AddAsync(tag);
            await this.tagsRepository.SaveChangesAsync();
        }

        public async Task DeleteTagAsync(TagViewModel input)
        {
            var tag = this.tagsRepository.AllAsNoTracking().Where(x => x.Name == input.Name).FirstOrDefault();
            this.tagsRepository.Delete(tag);
            await this.tagsRepository.SaveChangesAsync();
        }

        public IEnumerable<T> ShowAll<T>()
        {
            return this.tagsRepository.All().To<T>().ToList();
        }
    }
}
