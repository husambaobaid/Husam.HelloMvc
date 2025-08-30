using System.ComponentModel.DataAnnotations;

namespace Husam.HelloMvc.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Title { get; set; } = string.Empty;

        public bool IsDone { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
