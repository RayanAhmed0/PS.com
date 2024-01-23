using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProductStore.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        [ValidateNever] // to stop validating this property and will remove the issue we have while creating a product
        public IEnumerable<SelectListItem> CategoryList { get; set; } // for the drop down list
    }
}