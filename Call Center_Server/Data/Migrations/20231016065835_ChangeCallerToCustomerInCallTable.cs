using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Call_Center_Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCallerToCustomerInCallTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceivingCallName",
                table: "Calls",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "CallerPhone",
                table: "Calls",
                newName: "CustomerPhone");

            migrationBuilder.RenameColumn(
                name: "CallerName",
                table: "Calls",
                newName: "AgentEmployeeName");

            migrationBuilder.RenameColumn(
                name: "CallerEmail",
                table: "Calls",
                newName: "CustomerEmail");

            migrationBuilder.RenameColumn(
                name: "CallerCompanyName",
                table: "Calls",
                newName: "CustomerCompanyName");

            migrationBuilder.RenameColumn(
                name: "CallerAddress",
                table: "Calls",
                newName: "CustomerCompanyAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerPhone",
                table: "Calls",
                newName: "CallerPhone");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Calls",
                newName: "ReceivingCallName");

            migrationBuilder.RenameColumn(
                name: "CustomerEmail",
                table: "Calls",
                newName: "CallerEmail");

            migrationBuilder.RenameColumn(
                name: "CustomerCompanyName",
                table: "Calls",
                newName: "CallerCompanyName");

            migrationBuilder.RenameColumn(
                name: "CustomerCompanyAddress",
                table: "Calls",
                newName: "CallerAddress");

            migrationBuilder.RenameColumn(
                name: "AgentEmployeeName",
                table: "Calls",
                newName: "CallerName");
        }
    }
}
