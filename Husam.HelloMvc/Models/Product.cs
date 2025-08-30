using System.ComponentModel.DataAnnotations;

namespace Husam.HelloMvc.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 100000)]
        public decimal Price { get; set; }

        [Range(0, 100000)]
        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}