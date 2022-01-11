using System.ComponentModel.DataAnnotations;

namespace Assignment_CRUD.Models
{
    public class Order
    {
        [Key]
        [Required]

        public int Productid { get; set; }
        [Required]
        [Display(Name ="Enter Product Name: ")]
        [StringLength(50, MinimumLength =10)]
        public string ProductName { get; set; }
        [Required]
        [Display(Name ="Enter the Product Quantity:")]
        public int Quantity { get; set; }
        [Required]
        [Display(Name = "Enter the Product Price:")]
        public decimal Productprice { get; set; }
        [StringLength(100, MinimumLength = 10)]
        public string Description { get; set; }
        public decimal Total { get; set; }
    }
}
