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
}
