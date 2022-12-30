using Module1Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Module1Model.ViewModels
{
    public class AdminUserVM
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public int AdminUserRoleId { get; set; }

        public List<string> AdminUserNames { get; set; }
    }
}
