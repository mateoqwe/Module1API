using System.ComponentModel.DataAnnotations;

namespace Module1Model.Models
{
    public class Screen
    {
        [Key]
        public int ScreenId { get; set; }

        [Required]
        public string ScreenName { get; set; }
    }
}
