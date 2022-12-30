using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module1DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class GetAdminUserInfoViewNamingConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW dbo.GetAdminUserInfo
                AS
                SELECT u.AdminUserId, u.UserName, u.AdminUserRoleId, r.RoleName
                FROM dbo.AdminUsers u
                LEFT JOIN dbo.AdminUserRoles r
                ON u.AdminUserRoleId = r.AdminUserRoleId;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.GetAdminUserInfo");
        }
    }
}
