using System.ComponentModel.DataAnnotations;

namespace Module1Model.Models
{
    public class AdminUserRole
    {
        [Key]
        public int AdminUserRoleId { get; set; }

        [Required]
        public string RoleName { get; set; }

        public int? RolePower { get; set; }

        public List<AdminUser>? AdminUsers { get; set; }
    }
}
