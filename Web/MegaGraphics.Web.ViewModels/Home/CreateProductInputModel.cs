namespace MegaGraphics.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MegaGraphics.Data.Models;
    using MegaGraphics.Services.Mapping;

    public class CreateProductInputModel : IMapFrom<Tag>
    {
        public CreateProductInputModel()
        {
            this.Tags = new HashSet<Tag>();
        }

        [MinLength(3)]
        public string TagName { get; set; }

        public Tag Tag { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
