using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module1DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NamingConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers");

            migrationBuilder.RenameColumn(
                name: "screenName",
                table: "Screens",
                newName: "ScreenName");

            migrationBuilder.RenameColumn(
                name: "screenId",
                table: "Screens",
                newName: "ScreenId");

            migrationBuilder.RenameColumn(
                name: "userName",
                table: "AdminUsers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "AdminUsers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "adminUserRoleId",
                table: "AdminUsers",
                newName: "AdminUserRoleId");

            migrationBuilder.RenameColumn(
                name: "adminUserId",
                table: "AdminUsers",
                newName: "AdminUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AdminUsers_adminUserRoleId",
                table: "AdminUsers",
                newName: "IX_AdminUsers_AdminUserRoleId");

            migrationBuilder.RenameColumn(
                name: "rolePower",
                table: "AdminUserRoles",
                newName: "RolePower");

            migrationBuilder.RenameColumn(
                name: "roleName",
                table: "AdminUserRoles",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "adminUserRoleId",
                table: "AdminUserRoles",
                newName: "AdminUserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_AdminUserRoleId",
                table: "AdminUsers",
                column: "AdminUserRoleId",
                principalTable: "AdminUserRoles",
                principalColumn: "AdminUserRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_AdminUserRoleId",
                table: "AdminUsers");

            migrationBuilder.RenameColumn(
                name: "ScreenName",
                table: "Screens",
                newName: "screenName");

            migrationBuilder.RenameColumn(
                name: "ScreenId",
                table: "Screens",
                newName: "screenId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AdminUsers",
                newName: "userName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "AdminUsers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "AdminUserRoleId",
                table: "AdminUsers",
                newName: "adminUserRoleId");

            migrationBuilder.RenameColumn(
                name: "AdminUserId",
                table: "AdminUsers",
                newName: "adminUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AdminUsers_AdminUserRoleId",
                table: "AdminUsers",
                newName: "IX_AdminUsers_adminUserRoleId");

            migrationBuilder.RenameColumn(
                name: "RolePower",
                table: "AdminUserRoles",
                newName: "rolePower");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "AdminUserRoles",
                newName: "roleName");

            migrationBuilder.RenameColumn(
                name: "AdminUserRoleId",
                table: "AdminUserRoles",
                newName: "adminUserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminUsers_AdminUserRoles_adminUserRoleId",
                table: "AdminUsers",
                column: "adminUserRoleId",
                principalTable: "AdminUserRoles",
                principalColumn: "adminUserRoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
