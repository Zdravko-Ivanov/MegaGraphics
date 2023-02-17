namespace MegaGraphics.Web.ViewModels.Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MegaGraphics.Data.Models;
    using MegaGraphics.Services.Mapping;

    public class TagViewModel : IMapFrom<Tag>
    {
        public TagViewModel()
        {
            this.Tags = new HashSet<TagViewModel>();
        }

        [MinLength(3)]
        [Required]
        public string Name { get; set; }

        public IEnumerable<TagViewModel> Tags { get; set; }
    }
}
