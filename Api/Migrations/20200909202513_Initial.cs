using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Show = table.Column<int>(nullable: true),
                    Admin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tech" },
                    { 2, "Animals" },
                    { 3, "World" },
                    { 4, "Politics" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "PostId", "Text", "Time", "UserId" },
                values: new object[,]
                {
                    { 20, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 21, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 23, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 24, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 27, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 19, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 29, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 30, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 31, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 32, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 26, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 18, 6, "Gozel Post6", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 1, 1, "Gozel Post1", new DateTime(2008, 3, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 1, "Gozel Post1", new DateTime(2008, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 2, "Gozel Post2", new DateTime(2008, 3, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 2, "Gozel Post2", new DateTime(2008, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, 3, "Gozel Post3", new DateTime(2008, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, 4, "Gozel Post4", new DateTime(2008, 3, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 2, "Gozel Post2", new DateTime(2008, 3, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 13, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, 5, "Gozel Post5", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, 4, "Gozel Post4", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 7, "Anastasiya@gmail.com", "Anastasiya", "Anastasiya123" },
                    { 1, "Jean@gmail.com", "Jean", "Jean123" },
                    { 2, "Anna@gmail.com", "Anna", "Anna123" },
                    { 3, "Jon@gmail.com", "Jon", "Jon123" },
                    { 4, "Alison@gmail.com", "Alison", "Alison123" },
                    { 5, "Mike@gmail.com", "Mike", "Mike123" },
                    { 6, "Jony@gmail.com", "Jony", "Jony123" },
                    { 8, "Coni@gmail.com", "Coni", "Coni123" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Admin", "CategoryId", "Content", "Show", "Text", "Time" },
                values: new object[,]
                {
                    { 1, null, 1, "Post1", 8, "Post1 Cateogry1 Text asdasdasdasd", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, 1, "Post2", 8, "Post2 Category1 Text dfgfdgfgfgfdgfd", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, 1, "Post3", 34, "Post3 Category1 Text dfgdfgfdgfdgdf", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, 2, "Post4", 5, "Post4 Category2 Text l,glmtomgormf", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, 2, "Post5", 234, "Post5 Category2 Text msdfmsl;dfm", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, 3, "Post6", 45, "Post6 Category3 Text pppp,asd, aas,s", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, 3, "Post7", 11, "Post7 Category3 Text sadfgkusdstujhhtjh", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, 3, "Post8", 34, "Post8 Category3 Text jhgmxdnsbdjurt jtg jgf", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, 3, "Post9", 55, "Post9 Category3 Text scrw356v5e7v6ruvuv", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, 3, "Post10", 67, "Post10 Category3 Textk9mkuj262626fhfh hfdh", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, 4, "Post11", 1, "Post11 Category4 Text wweqqwweqqqwe", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, 4, "Post12", 90, "Post12 Category4 Text aaaaaagggggggrrrrrrreeeeeeeeeg 343434", new DateTime(2008, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_CategoryId",
                table: "Post",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
