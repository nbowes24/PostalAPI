using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PostalWebApi.Migrations
{
    public partial class Intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Category",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CategoryText = table.Column<string>(nullable: true),
            //        DisplayOrder = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Category", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Menu",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FoodDescription = table.Column<string>(nullable: true),
            //        Price = table.Column<decimal>(nullable: false),
            //        Available = table.Column<bool>(nullable: false),
            //        CategoryId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Menu", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Staff",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FirstName = table.Column<string>(nullable: true),
            //        LastName = table.Column<string>(nullable: true),
            //        Pin = table.Column<int>(nullable: false),
            //        AdminFlag = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Staff", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TableNum",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        StaffId = table.Column<int>(nullable: true),
            //        TableNumber = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TableNum", x => x.Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "TableNum");
        }
    }
}
