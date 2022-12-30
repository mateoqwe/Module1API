using Module1Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Module1Model.ViewModels
{
    public class AdminUserRoleVM
    {
        public string RoleName { get; set; }

        public int? RolePower { get; set; }
    }

    public class AdminUserRoleWithAdminUserVM
    {
        public string RoleName { get; set; }

        public int? RolePower { get; set; }

        public List<string> AdminUserNames { get; set; }
    }
}
