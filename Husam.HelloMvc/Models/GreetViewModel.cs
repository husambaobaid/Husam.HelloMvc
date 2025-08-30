using System.ComponentModel.DataAnnotations;

namespace Husam.HelloMvc.Models
{
    public class GreetViewModel
    {
        [Display(Name = "Your name")]
        [Required, StringLength(40)]
        public string? Name { get; set; }

        // We’ll fill this after POST to show the greeting
        public string? Message { get; set; }
    }
}