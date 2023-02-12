namespace MegaGraphics.Web.Controllers
{
    using MegaGraphics.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]

        public IActionResult Create(CreateProductInputModel input)
        {
            if (this.ModelState.IsValid)
            {
                return this.View();
            }

            //TODO: Create via service
            //TODO: Redirect

            return this.Redirect("/");
        }
    }
}
