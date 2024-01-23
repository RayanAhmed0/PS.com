using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStore.Models
{
    public class Product
    {
        [Key] // This [Key] is a data annotation that will tell the database that this is the primary key ,
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, 10000)]
        public double Price { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever] // to stop validating this property and will remove the issue we have while creating a product
        public Category Category { get; set; } // Navigation property to the Category Table

        [ValidateNever]
        public List<ProductImage> ProductImages { get; set; } // a list containing all the product images as the prodduct and product image relation is one to many
    }
}