using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop2.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description  { get; set; }
        [Required]
        [Display(Name ="Quantity")]
        public int proQuantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Image { get; set; }
        [Display(Name ="Product Color")]
        public string ProductColor { get; set; }
        [Required,Display(Name ="Available")]
        public bool IsAvailable { get; set; }

        [Required,Display(Name ="Product Type")]
        public int ProductTypeId   { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductTypes ProductType { get; set; }
        [Required,Display(Name ="Special Tag")]
        public int SpecialTagId { get; set; }
        [ForeignKey("SpecialTagId")]
        public SpecialTag SpecialTag { get; set; }
    }
}
