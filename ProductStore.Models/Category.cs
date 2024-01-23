using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductStore.Models
{
    public class Category
    {
        [Key] // This [Key] is a data annotation that will tell the database that this is the primary key ,
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Range(1, 100)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}