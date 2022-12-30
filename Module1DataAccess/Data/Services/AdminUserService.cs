using Module1Model.Models;
using Module1Model.ViewModels;
using System.Data;

namespace Module1DataAccess.Data.Services
{
    public class AdminUserService
    {
        private ApplicationDbContext _context;

        public AdminUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddAdminUser(AdminUserVM adminUserVM)
        {
            var _adminUser = new AdminUser()
            {
                UserName= adminUserVM.UserName,
                Password= adminUserVM.Password,
                AdminUserRoleId= adminUserVM.AdminUserRoleId
            };

            _context.AdminUsers.Add(_adminUser);
            _context.SaveChanges();
        }
        public List<AdminUserFromView> GetAllAdminUser()
        {
            return _context.AdminUserFromViews.ToList();
        }

        public AdminUserWithRoleVM GetAdminUserById(int id)
        {
            var _adminUserWithRole = _context.AdminUsers.Where(u => u.AdminUserId == id).Select(user => new AdminUserWithRoleVM()
            {
                UserName= user.UserName,
                Password= user.Password,
                AdminUserRoleName = user.AdminUserRole.RoleName
            }).FirstOrDefault();

            return _adminUserWithRole;
        }

        public AdminUser UpdateAdminUserById(int id, AdminUserVM adminUserVM)
        {
            var _adminUser = _context.AdminUsers.FirstOrDefault(u => u.AdminUserId == id);
            if (_adminUser != null)
            {
                _adminUser.UserName = adminUserVM.UserName;
                _adminUser.Password = adminUserVM.Password;
                _adminUser.AdminUserRoleId = adminUserVM.AdminUserRoleId;

                _context.SaveChanges();
            }

            return _adminUser;
        }

        public void DeleteAdminUserById(int id)
        {
            var _adminUser = _context.AdminUsers.FirstOrDefault(u => u.AdminUserId == id);
            if (_adminUser != null)
            {
                _context.AdminUsers.Remove(_adminUser);
                _context.SaveChanges();
            }
        }
    }
}
