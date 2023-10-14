using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Call_Center_Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCallTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CallerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CallDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CallerCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallsUrgency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivingCallName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CallStage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calls");
        }
    }
}
