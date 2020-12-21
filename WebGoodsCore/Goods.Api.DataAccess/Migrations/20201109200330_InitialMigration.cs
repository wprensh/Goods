using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Goods.Api.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    SurName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(nullable: false),
                    BookingDate = table.Column<DateTime>(nullable: false),
                    CrearteDate = table.Column<DateTime>(nullable: false),
                    IdOffice = table.Column<int>(nullable: false),
                    RenWorkSpace = table.Column<bool>(nullable: false),
                    IdRoom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Officess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Addess = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IdAdmin = table.Column<int>(nullable: false),
                    HasIndividualWorkSpace = table.Column<bool>(nullable: false),
                    NumberWorkSpace = table.Column<int>(nullable: false),
                    ProceWorkSpaceDetail = table.Column<decimal>(nullable: false),
                    ProceWorkSpaceMothly = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Officess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    SurName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreateData = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficessAndRooms",
                columns: table => new
                {
                    IdOffice = table.Column<int>(nullable: false),
                    IdRoom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficessAndRooms", x => new { x.IdOffice, x.IdRoom });
                    table.ForeignKey(
                        name: "FK_OfficessAndRooms_Officess_IdOffice",
                        column: x => x.IdOffice,
                        principalTable: "Officess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfficessAndRooms_Rooms_IdRoom",
                        column: x => x.IdRoom,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomAndSercices",
                columns: table => new
                {
                    IdRomm = table.Column<int>(nullable: false),
                    IdService = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAndSercices", x => new { x.IdRomm, x.IdService });
                    table.ForeignKey(
                        name: "FK_RoomAndSercices_Rooms_IdRomm",
                        column: x => x.IdRomm,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomAndSercices_Services_IdService",
                        column: x => x.IdService,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OfficessAndRooms_IdRoom",
                table: "OfficessAndRooms",
                column: "IdRoom");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAndSercices_IdService",
                table: "RoomAndSercices",
                column: "IdService");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "OfficessAndRooms");

            migrationBuilder.DropTable(
                name: "RoomAndSercices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Officess");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
