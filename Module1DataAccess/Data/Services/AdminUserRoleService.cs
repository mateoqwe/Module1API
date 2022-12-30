using Module1Model.Models;
using Module1Model.ViewModels;

namespace Module1DataAccess.Data.Services
{
    public class AdminUserRoleService
    {
        private ApplicationDbContext _context;

        public AdminUserRoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddAdminUserRole(AdminUserRoleVM adminUserRoleVM)
        {
            var _adminUserRole = new AdminUserRole()
            {
                RoleName = adminUserRoleVM.RoleName,
                RolePower= adminUserRoleVM.RolePower,
            };

            _context.AdminUserRoles.Add(_adminUserRole);
            _context.SaveChanges();
        }
        public List<AdminUserRole> GetAllAdminUserRole()
        {
            return _context.AdminUserRoles.ToList();
        }

        public AdminUserRoleWithAdminUserVM GetAdminUserRoleById(int id)
        {
            var _adminUserRoleWithAdmniUser = _context.AdminUserRoles.Where(n => n.AdminUserRoleId == id).Select(role => new AdminUserRoleWithAdminUserVM()
            {
                RoleName = role.RoleName,
                RolePower = role.RolePower,
                AdminUserNames = role.AdminUsers.Select(au => au.UserName).ToList()
            }).FirstOrDefault();

            return _adminUserRoleWithAdmniUser;
        }

        public AdminUserRole UpdateAdminUserRoleById(int id, AdminUserRoleVM adminUserRoleVM)
        {
            var _adminUserRole = _context.AdminUserRoles.FirstOrDefault(r => r.AdminUserRoleId == id);
            if (_adminUserRole != null)
            {
                _adminUserRole.RoleName = adminUserRoleVM.RoleName;
                _adminUserRole.RolePower = adminUserRoleVM.RolePower;

                _context.SaveChanges();
            }

            return _adminUserRole;
        }

        public void DeleteAdminUserRoleById(int id)
        {
            var _adminUserRole = _context.AdminUserRoles.FirstOrDefault(r => r.AdminUserRoleId == id);
            if (_adminUserRole != null)
            {
                _context.AdminUserRoles.Remove(_adminUserRole);
                _context.SaveChanges();
            }
        }
    }
}
