namespace MegaGraphics.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MegaGraphics.Web.ViewModels.Product;

    public interface ITagService
    {
        Task AddTagAsync(TagViewModel input);

        Task DeleteTagAsync(TagViewModel input);

        IEnumerable<T> ShowAll<T>();
    }
}
