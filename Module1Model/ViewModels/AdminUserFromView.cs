using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Model.ViewModels
{
    public class AdminUserFromView
    {
        public int AdminUserId { get; set; }

        public string UserName { get; set; }

        public int AdminUserRoleId { get; set; }

        public string RoleName { get; set; }
    }
}
