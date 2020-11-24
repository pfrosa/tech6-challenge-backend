using System.ComponentModel.DataAnnotations;

namespace tech6_challenge_backend.Models
{
    public class  Todo{
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Content { get; set; }
    }
}