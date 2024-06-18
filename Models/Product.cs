using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün Id")]
        
        public int ProductId { get; set; }
        [Display(Name = "Ürün Adı")]
        [Required]

        public string Name { get; set; } = null!;
        [Display(Name = "Ürün Fiyatı")]
        [Required]
        public decimal? Price { get; set; }
        [Display(Name = "Ürün Görseli")]
        public string? Image { get; set; }


        public bool IsActive { get; set; }



        [Display(Name = "Kategori ")]
        [Required]

        public int? CategoryId { get; set; }
    }
}