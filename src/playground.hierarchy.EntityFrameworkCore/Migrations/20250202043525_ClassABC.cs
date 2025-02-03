using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace playground.hierarchy.Migrations
{
    /// <inheritdoc />
    public partial class ClassABC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppClassAs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClassAs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppClassBs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Property1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClassBs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppClassBs_AppClassAs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AppClassAs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppClassCs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClassCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppClassCs_AppClassBs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AppClassBs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppClassBs_ParentId",
                table: "AppClassBs",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppClassCs_ParentId",
                table: "AppClassCs",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppClassCs");

            migrationBuilder.DropTable(
                name: "AppClassBs");

            migrationBuilder.DropTable(
                name: "AppClassAs");
        }
    }
}
