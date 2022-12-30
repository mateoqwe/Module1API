using Microsoft.AspNetCore.Mvc;
using Module1DataAccess.Data.Services;
using Module1Model.ViewModels;

namespace Module1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        private AdminUserService _adminUserService;

        public AdminUserController(AdminUserService adminUserService)
        {
            _adminUserService = adminUserService;
        }

        [HttpGet("get-all-admin-user")]
        public IActionResult GetAllAdminUser()
        {
            var _allAdminUser = _adminUserService.GetAllAdminUser();
            return Ok(_allAdminUser);
        }

        [HttpGet("get-admin-user-by-id/{id}")]
        public IActionResult GetAdminUserById(int id)
        {
            var _adminUser = _adminUserService.GetAdminUserById(id);
            return Ok(_adminUser);
        }

        [HttpPost("add-admin-user")]
        public IActionResult AddAdminUserRole([FromBody] AdminUserVM adminUserVM)
        {
            _adminUserService.AddAdminUser(adminUserVM);
            return Ok();
        }

        [HttpPut("udpate-admin-user-by-id/{id}")]
        public IActionResult UpdateAdminUserById(int id, [FromBody] AdminUserVM adminUserVM)
        {
            var _updateAdminUser = _adminUserService.UpdateAdminUserById(id, adminUserVM);
            return Ok(_updateAdminUser);
        }

        [HttpDelete("delete-admin-user-by-id/{id}")]
        public IActionResult DeleteAdminUserById(int id)
        {
            _adminUserService.DeleteAdminUserById(id);
            return Ok();
        }
    }
}
