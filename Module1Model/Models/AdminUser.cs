using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module1Model.Models
{
    public class AdminUser
    {
        [Key]
        public int AdminUserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [ForeignKey("AdminUserRole")]
        public int AdminUserRoleId { get; set; }

        public AdminUserRole AdminUserRole { get; set; }
    }
}
