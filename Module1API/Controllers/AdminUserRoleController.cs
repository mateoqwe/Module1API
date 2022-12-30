using Microsoft.AspNetCore.Mvc;
using Module1DataAccess.Data.Services;
using Module1Model.ViewModels;

namespace Module1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserRoleController : ControllerBase
    {
        private AdminUserRoleService _adminUserRoleService;

        public AdminUserRoleController(AdminUserRoleService adminUserRoleService)
        {
            _adminUserRoleService = adminUserRoleService;
        }

        [HttpGet("get-admin-user-role-by-id/{id}")]
        public IActionResult GetAdminUserRoleById(int id)
        {
            var _adminUserRole = _adminUserRoleService.GetAdminUserRoleById(id);
            return Ok(_adminUserRole);
        }

        [HttpPost("add-admin-user-role")]
        public IActionResult AddAdminUserRole([FromBody] AdminUserRoleVM adminUserRoleVM)
        {
            _adminUserRoleService.AddAdminUserRole(adminUserRoleVM);
            return Ok();
        }

        [HttpPut("udpate-admin-user-role-by-id/{id}")]
        public IActionResult UpdateAdminUserRoleById(int id, [FromBody] AdminUserRoleVM adminUserRoleVM)
        {
            var _updateAdminUserRole = _adminUserRoleService.UpdateAdminUserRoleById(id, adminUserRoleVM);
            return Ok(_updateAdminUserRole);
        }

        [HttpDelete("delete-admin-user-role-by-id/{id}")]
        public IActionResult DeleteAdminUserRoleById(int id)
        {
            _adminUserRoleService.DeleteAdminUserRoleById(id);
            return Ok();
        }
    }
}
