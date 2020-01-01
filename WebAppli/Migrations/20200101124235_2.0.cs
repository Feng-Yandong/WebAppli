using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppli.Migrations
{
    public partial class _20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addupto",
                columns: table => new
                {
                    Aid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aoid = table.Column<string>(nullable: true),
                    Agid = table.Column<int>(nullable: true),
                    AsumN = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addupto", x => x.Aid);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Gid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gname = table.Column<string>(nullable: true),
                    Gimg = table.Column<string>(nullable: true),
                    Gdescribe = table.Column<string>(nullable: true),
                    Gprice = table.Column<int>(nullable: true),
                    Gsum = table.Column<int>(nullable: true),
                    Gtai = table.Column<int>(nullable: true),
                    Ginventory = table.Column<int>(nullable: true),
                    Gtype = table.Column<int>(nullable: true),
                    Gint = table.Column<int>(nullable: true),
                    Gstring = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Gid);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Lid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lname = table.Column<string>(nullable: true),
                    Lphone = table.Column<string>(nullable: true),
                    Lonation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Lid);
                });

            migrationBuilder.CreateTable(
                name: "Merchant",
                columns: table => new
                {
                    Mid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mname = table.Column<string>(nullable: true),
                    Mweixin = table.Column<string>(nullable: true),
                    Mphone = table.Column<string>(nullable: true),
                    Mpwd = table.Column<string>(nullable: true),
                    Msite = table.Column<string>(nullable: true),
                    Mimg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant", x => x.Mid);
                });

            migrationBuilder.CreateTable(
                name: "Orderform",
                columns: table => new
                {
                    Oid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Orders = table.Column<string>(nullable: true),
                    Otime = table.Column<DateTime>(nullable: false),
                    Oshou = table.Column<int>(nullable: true),
                    Aowid = table.Column<int>(nullable: true),
                    Alid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderform", x => x.Oid);
                });

            migrationBuilder.CreateTable(
                name: "Shopping",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sgid = table.Column<int>(nullable: true),
                    Shu = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopping", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "TypeGoods",
                columns: table => new
                {
                    Tid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tname = table.Column<string>(nullable: true),
                    Tstring = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeGoods", x => x.Tid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addupto");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Merchant");

            migrationBuilder.DropTable(
                name: "Orderform");

            migrationBuilder.DropTable(
                name: "Shopping");

            migrationBuilder.DropTable(
                name: "TypeGoods");
        }
    }
}
