using System.ComponentModel.DataAnnotations;

namespace Beauty_store.Models
{
    public class ProductItems
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name field cannot be empty")]
        [MinLength(5, ErrorMessage = "Enter minimum 5 simbols")]
        [Display(Name = "Name of products")]
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public double Price { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Display(Name = "Quantity in stock")]
        public int Count { get; set; }
        [Required(ErrorMessage = "The Image field cannot be empty")]
        [Display(Name = "Url of product image")]
        public string Image { get; set; }
    }
}
