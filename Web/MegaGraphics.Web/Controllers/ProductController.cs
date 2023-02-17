namespace MegaGraphics.Web.Controllers
{
    using System.Threading.Tasks;

    using MegaGraphics.Services;
    using MegaGraphics.Services.Data;
    using MegaGraphics.Web.ViewModels.Home;
    using MegaGraphics.Web.ViewModels.Product;
    using Microsoft.AspNetCore.Mvc;

    public class ProductController : Controller
    {
        private readonly ITagService tagService;
        private readonly ICategoryService categoryService;

        public ProductController(ITagService tagService, ICategoryService categoryService)
        {
            this.tagService = tagService;
            this.categoryService = categoryService;
        }

        public IActionResult Tag()
        {
            var tags = this.tagService.ShowAll<TagViewModel>();
            var viewModel = new TagViewModel { Tags = tags };
            return this.View(viewModel);
        }

        [HttpPost]

        public async Task<IActionResult> Tag(TagViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.tagService.AddTagAsync(input);

            input.Tags = this.tagService.ShowAll<TagViewModel>();

            return this.View(input);
        }

        [HttpPost]
        public async Task<IActionResult> TagDelete(TagViewModel input)
        {
            await this.tagService.DeleteTagAsync(input);

            return this.RedirectToAction(nameof(this.Tag));
        }

        public IActionResult Category()
        {
            var categories = this.categoryService.ShowAll<CategoryViewModel>();
            var viewModel = new CategoryViewModel { Categories = categories };
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Category(CategoryViewModel input)
        {
            var categories = this.categoryService.ShowAll<CategoryViewModel>();
            var viewModel = new CategoryViewModel { Categories = categories };
            return this.View(viewModel);
        }
    }
}
