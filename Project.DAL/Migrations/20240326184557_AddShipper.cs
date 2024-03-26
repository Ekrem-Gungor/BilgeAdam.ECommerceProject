using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddShipper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "ShipperID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ActivationCode",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "744dfdf7-0688-48ca-adc0-139d18c9e114");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivationCode", "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "c1fca2a9-18a2-4f94-90a1-691d5f641180", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(3729), "AQAAAAIAAYagAAAAEMkn2hElyD6lqGx28KK9hsCa9vhjxD6OCLNELeuxEEIbXqo6qxv4RTiXO3Uo29DywA==", "f04db5ac-fe7d-4197-a693-7804197b119f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(1404), "Enim lakin inventore reprehenderit gidecekmiş koyun ama voluptatem dağılımı ea." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(1760), "Praesentium türemiş okuma filmini aliquam koşuyorlar blanditiis rem alias quae." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(1840), "Sokaklarda masaya deleniti sequi reprehenderit dolore incidunt nesciunt magnam magnam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(1957), "Nostrum totam eve et quia quia kutusu eaque consequatur amet." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2025), "İncidunt qui patlıcan çakıl teldeki alias gidecekmiş dicta bundan quaerat." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2091), "Ekşili ipsum sinema ışık sit mutlu nostrum et odio dolor." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2165), "Exercitationem çıktılar molestiae autem aut aut okuma umut masaya doğru." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2284), "Sıla gülüyorum sequi çorba qui blanditiis camisi ekşili şafak masaya." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2353), "Dışarı quia praesentium tempora doğru consequatur ea sayfası nisi dışarı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2416), "Biber in eos gördüm gülüyorum tempora bilgiyasayarı aspernatur doğru kalemi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2533), "Generic Steel Hat", 746.10m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2835), "Licensed Plastic Keyboard", 730.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2910), "Gorgeous Plastic Fish", 709.42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(2976), "Intelligent Rubber Cheese", 926.91m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(3046), "Refined Frozen Hat", 522.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(3111), "Intelligent Fresh Chicken", 197.47m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(3204), "Refined Concrete Car", 143.26m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(3268), "Generic Frozen Keyboard", 852.57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(3330), "Refined Wooden Mouse", 769.90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 45, 56, 258, DateTimeKind.Local).AddTicks(3395), "Unbranded Wooden Chips", 529.58m });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders",
                column: "ShipperID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperID",
                table: "Orders",
                column: "ShipperID",
                principalTable: "Shippers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShipperID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipperID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ActivationCode",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d176a4ec-ef63-46c5-affd-e7b8bf6aff2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eb40bd1-e453-400e-9deb-17489ddde035", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(6342), "AQAAAAIAAYagAAAAEOKUDt0bjW6YTU+QU4gnM5wSqQ5zZKXVCwMUPFt83Ii2Cfj+tdi2DwcEJyWGHsqQsQ==", "f2dddbf4-67c5-42e3-aaae-cdbf9c4ca99f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Outdoors", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4131), "Oldular sinema voluptatem velit de aliquam ut sıla non otobüs." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Electronics", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4492), "Gazete corporis adresini dolores dağılımı voluptatem sıradanlıktan uzattı ut praesentium." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Garden", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4565), "Balıkhaneye çorba enim ea dergi doğru et vitae ex mıknatıslı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Games", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4636), "De corporis reprehenderit dolores gidecekmiş aliquam ut orta ama illo." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "Description" },
                values: new object[] { null, new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4733), "Dignissimos gazete tempora aut et adresini eaque iusto ex iure." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Clothing", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4801), "Dicta voluptatem quia voluptatem adanaya adresini voluptatem quaerat ducimus veritatis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Clothing", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4864), "De gidecekmiş enim ut balıkhaneye ut consequuntur anlamsız ut lambadaki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Outdoors", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(4926), "Sayfası yaptı odit quis numquam sequi labore doloremque iusto eos." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Kids", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5021), "Koştum sayfası telefonu kapının bundan ki inventore aperiam göze quia." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "Description" },
                values: new object[] { null, "Home", new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5088), "Aperiam eum veritatis aut voluptatum vel gül orta değerli beğendim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5217), "Ergonomic Concrete Keyboard", 357.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5456), "Handmade Rubber Soap", 711.36m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5555), "Sleek Metal Bacon", 965.39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5625), "Incredible Fresh Shoes", 821.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5693), "Handmade Metal Hat", 979.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5760), "Ergonomic Wooden Tuna", 961.03m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5827), "Gorgeous Granite Car", 680.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(5940), "Awesome Granite Car", 799.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(6004), "Awesome Steel Soap", 632.58m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 44, 47, 889, DateTimeKind.Local).AddTicks(6068), "Awesome Steel Mouse", 353.29m });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryID",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryID",
                table: "Categories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");
        }
    }
}
