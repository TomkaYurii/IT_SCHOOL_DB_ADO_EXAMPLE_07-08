using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_Ex_01.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "QQQQQQQ" },
                    { 2, "QQQQQQQ" },
                    { 3, "QQQQQQQ" }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Discriminator", "DurationInMinutes", "Name", "Release", "WorldWideBoxOfficeGross" },
                values: new object[,]
                {
                    { 1, "Movie", 190, "0000skdngksd", new DateTime(2000, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000000 },
                    { 2, "Movie", 120, "1111sd", new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000000 },
                    { 3, "Movie", 150, "2222skdngksd", new DateTime(2010, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000000 }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Discriminator", "Name", "NumberofEpisodes", "Release" },
                values: new object[,]
                {
                    { 4, "Series", "asafsafdasd", 400, new DateTime(2000, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Series", "asfsdfsd", 4400, new DateTime(2000, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Series", "a1231234124sd", 400, new DateTime(2100, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ActorId", "Name", "ProductionId", "ProfuctionId" },
                values: new object[,]
                {
                    { 1, 1, "sdgsdg", null, 1 },
                    { 6, 1, "sdgs234g", null, 5 },
                    { 2, 2, "sdwwerweg", null, 2 },
                    { 5, 2, "s35sdg", null, 6 },
                    { 3, 3, "s123124dg", null, 1 },
                    { 4, 3, "s3254dg", null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductionId", "Source", "Stars" },
                values: new object[,]
                {
                    { 42, 5, "Internet", 1 },
                    { 41, 5, "NewsPapers", 4 },
                    { 39, 4, "Magazine", 4 },
                    { 38, 4, "NewsPapers", 3 },
                    { 37, 4, "Group", 1 },
                    { 34, 4, "NewsPapers", 6 },
                    { 35, 4, "Internet", 1 },
                    { 43, 5, "Group", 2 },
                    { 33, 4, "NewsPapers", 5 },
                    { 32, 4, "Magazine", 1 },
                    { 36, 4, "Internet", 6 },
                    { 44, 5, "Internet", 6 },
                    { 47, 5, "Magazine", 1 },
                    { 46, 5, "Group", 7 },
                    { 31, 4, "NewsPapers", 1 },
                    { 48, 5, "Internet", 7 },
                    { 49, 5, "Internet", 1 },
                    { 51, 6, "Group", 6 },
                    { 52, 6, "Internet", 6 },
                    { 53, 6, "Magazine", 5 },
                    { 54, 6, "NewsPapers", 6 },
                    { 55, 6, "Magazine", 2 },
                    { 56, 6, "NewsPapers", 3 },
                    { 57, 6, "Internet", 5 },
                    { 45, 5, "NewsPapers", 4 },
                    { 29, 3, "Internet", 1 },
                    { 26, 3, "Internet", 1 },
                    { 27, 3, "Magazine", 4 },
                    { 1, 1, "Group", 2 },
                    { 2, 1, "Internet", 1 },
                    { 3, 1, "NewsPapers", 1 },
                    { 4, 1, "Magazine", 5 },
                    { 5, 1, "NewsPapers", 6 },
                    { 6, 1, "Internet", 7 },
                    { 7, 1, "Magazine", 7 },
                    { 8, 1, "Group", 3 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductionId", "Source", "Stars" },
                values: new object[,]
                {
                    { 9, 1, "Group", 7 },
                    { 11, 2, "Internet", 1 },
                    { 12, 2, "Group", 1 },
                    { 28, 3, "Group", 4 },
                    { 13, 2, "NewsPapers", 7 },
                    { 15, 2, "NewsPapers", 4 },
                    { 16, 2, "Magazine", 5 },
                    { 17, 2, "Group", 5 },
                    { 18, 2, "Internet", 1 },
                    { 19, 2, "Group", 3 },
                    { 21, 3, "NewsPapers", 4 },
                    { 22, 3, "Magazine", 4 },
                    { 23, 3, "Group", 7 },
                    { 24, 3, "Group", 5 },
                    { 25, 3, "NewsPapers", 6 },
                    { 58, 6, "Group", 2 },
                    { 14, 2, "Magazine", 5 },
                    { 59, 6, "Magazine", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productions",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
