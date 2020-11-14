using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaseStudy.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Description", "ImgUri", "Modified", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("095d7240-e0d9-40c9-91d0-01219e432994"), new DateTime(2020, 11, 14, 19, 47, 57, 331, DateTimeKind.Local).AddTicks(2959), "Popis k produktu č. 1", "https://cdn.alza.cz/Foto/1", null, "Produkt 1", 60934.71m },
                    { new Guid("b9dd3b68-8f07-4726-ba9a-b2da27c90267"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3082), "Popis k produktu č. 28", "https://cdn.alza.cz/Foto/28", null, "Produkt 28", 10761.08m },
                    { new Guid("8c14e86b-dd37-44bd-816a-9f797de01deb"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3089), "Popis k produktu č. 29", "https://cdn.alza.cz/Foto/29", null, "Produkt 29", 58059.81m },
                    { new Guid("940d9dd5-6b94-40ad-9e41-91ad9c80a3a1"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3095), "Popis k produktu č. 30", "https://cdn.alza.cz/Foto/30", null, "Produkt 30", 94937.11m },
                    { new Guid("3f5dde79-fc15-4d20-9ed0-82df0a30b9ba"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3102), "Popis k produktu č. 31", "https://cdn.alza.cz/Foto/31", null, "Produkt 31", 14527.54m },
                    { new Guid("4b84cfc1-5f58-4816-87d3-5c81d8760a88"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3110), "Popis k produktu č. 32", "https://cdn.alza.cz/Foto/32", null, "Produkt 32", 75291.04m },
                    { new Guid("2b6cde89-9405-4b8f-943b-154b0160919c"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3117), "Popis k produktu č. 33", "https://cdn.alza.cz/Foto/33", null, "Produkt 33", 40846.63m },
                    { new Guid("079768d7-566d-431e-a45d-4dae8ad435bc"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3124), "Popis k produktu č. 34", "https://cdn.alza.cz/Foto/34", null, "Produkt 34", 96295.51m },
                    { new Guid("3450aed9-9601-489d-b2b3-ccddc6aaadd6"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3136), "Popis k produktu č. 35", "https://cdn.alza.cz/Foto/35", null, "Produkt 35", 66690.32m },
                    { new Guid("e330b11a-f5e8-407d-a782-ab6bd6a299ef"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3143), "Popis k produktu č. 36", "https://cdn.alza.cz/Foto/36", null, "Produkt 36", 96296.48m },
                    { new Guid("16288937-b7e6-4905-9836-a9277fafdf4c"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3149), "Popis k produktu č. 37", "https://cdn.alza.cz/Foto/37", null, "Produkt 37", 60215.32m },
                    { new Guid("b9b91e33-a274-4f7a-ac48-66a0a18ebd67"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3156), "Popis k produktu č. 38", "https://cdn.alza.cz/Foto/38", null, "Produkt 38", 76229.73m },
                    { new Guid("9b5027ca-5eec-4950-9d95-691809662e6a"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3162), "Popis k produktu č. 39", "https://cdn.alza.cz/Foto/39", null, "Produkt 39", 32070.72m },
                    { new Guid("48afb1cb-48b5-45b3-9e3b-897f8dcb2d98"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3171), "Popis k produktu č. 40", "https://cdn.alza.cz/Foto/40", null, "Produkt 40", 18411.08m },
                    { new Guid("6d718676-6d85-4177-8939-428493b8ac8f"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3178), "Popis k produktu č. 41", "https://cdn.alza.cz/Foto/41", null, "Produkt 41", 66166.05m },
                    { new Guid("910be9f8-adce-4bc9-a422-91f321f3ff5e"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3184), "Popis k produktu č. 42", "https://cdn.alza.cz/Foto/42", null, "Produkt 42", 96886.58m },
                    { new Guid("61effdeb-b1ab-4b44-ad2f-65be8ea25b05"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3190), "Popis k produktu č. 43", "https://cdn.alza.cz/Foto/43", null, "Produkt 43", 88928.7m },
                    { new Guid("074b0ea0-d051-4b5f-a9be-f9307d651e1e"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3197), "Popis k produktu č. 44", "https://cdn.alza.cz/Foto/44", null, "Produkt 44", 74553.2m },
                    { new Guid("daa96732-085a-4bda-a2bd-8e9e075bcc78"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3203), "Popis k produktu č. 45", "https://cdn.alza.cz/Foto/45", null, "Produkt 45", 76173.65m },
                    { new Guid("bb6ccb61-cb90-4b63-8266-99e5e4d43068"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3209), "Popis k produktu č. 46", "https://cdn.alza.cz/Foto/46", null, "Produkt 46", 18484.67m },
                    { new Guid("4b2efe52-4f2e-464a-b028-384d3af8756c"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3216), "Popis k produktu č. 47", "https://cdn.alza.cz/Foto/47", null, "Produkt 47", 86673.59m },
                    { new Guid("6d9c8ea9-c3ea-406f-acef-4e1c9ef3fa55"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3224), "Popis k produktu č. 48", "https://cdn.alza.cz/Foto/48", null, "Produkt 48", 14858.15m },
                    { new Guid("5188a139-2d75-4ddd-bbc7-530937664fb7"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3075), "Popis k produktu č. 27", "https://cdn.alza.cz/Foto/27", null, "Produkt 27", 66779.59m },
                    { new Guid("318b2395-8cd9-45da-8fad-d00f0df8e4fb"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3069), "Popis k produktu č. 26", "https://cdn.alza.cz/Foto/26", null, "Produkt 26", 83979.3m },
                    { new Guid("0afaea95-2cd4-482c-a6ee-d5b46b3b524a"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3062), "Popis k produktu č. 25", "https://cdn.alza.cz/Foto/25", null, "Produkt 25", 9954.53m },
                    { new Guid("ece680e9-733f-46c6-b623-1f8b2957eae9"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3056), "Popis k produktu č. 24", "https://cdn.alza.cz/Foto/24", null, "Produkt 24", 39244.35m },
                    { new Guid("b20cc21c-bd7b-4b4d-adef-7a803ba0822e"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2742), "Popis k produktu č. 2", "https://cdn.alza.cz/Foto/2", null, "Produkt 2", 10984.36m },
                    { new Guid("c49f6761-88f7-4435-a314-57b4a0dd0ad2"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2861), "Popis k produktu č. 3", "https://cdn.alza.cz/Foto/3", null, "Produkt 3", 36912.23m },
                    { new Guid("f19a0026-8a12-49e8-b98a-ab1f51741743"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2872), "Popis k produktu č. 4", "https://cdn.alza.cz/Foto/4", null, "Produkt 4", 64143.43m },
                    { new Guid("bc528fe9-267c-4737-bd71-76b051965e25"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2879), "Popis k produktu č. 5", "https://cdn.alza.cz/Foto/5", null, "Produkt 5", 94813.25m },
                    { new Guid("87bbbbe4-2cea-423b-ab4a-644dc12dd5d9"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2891), "Popis k produktu č. 6", "https://cdn.alza.cz/Foto/6", null, "Produkt 6", 33958.95m },
                    { new Guid("cf4cf9c0-8e6e-43ad-8292-6b6acffc0299"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2897), "Popis k produktu č. 7", "https://cdn.alza.cz/Foto/7", null, "Produkt 7", 84494.96m },
                    { new Guid("af8a27d3-55b7-49eb-9c5d-6371929d49d7"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2915), "Popis k produktu č. 8", "https://cdn.alza.cz/Foto/8", null, "Produkt 8", 45288.2m },
                    { new Guid("42e26b81-b41e-4ce3-a364-9d34c05fa5e9"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2922), "Popis k produktu č. 9", "https://cdn.alza.cz/Foto/9", null, "Produkt 9", 86020.05m },
                    { new Guid("6db72a0f-d317-4136-8465-b986b03d9009"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2930), "Popis k produktu č. 10", "https://cdn.alza.cz/Foto/10", null, "Produkt 10", 17357.52m },
                    { new Guid("893cc0ab-0d0d-4800-9b85-34e94adb477d"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2937), "Popis k produktu č. 11", "https://cdn.alza.cz/Foto/11", null, "Produkt 11", 91160.92m },
                    { new Guid("03ebcb57-173e-4cda-8b83-bdd6d4c06eba"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3231), "Popis k produktu č. 49", "https://cdn.alza.cz/Foto/49", null, "Produkt 49", 16935.03m },
                    { new Guid("03473e4b-8ac6-4416-8a8d-9c7fd8528bf5"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2944), "Popis k produktu č. 12", "https://cdn.alza.cz/Foto/12", null, "Produkt 12", 33775.17m },
                    { new Guid("02abee1d-cc09-4846-a677-7d493fe28d50"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2956), "Popis k produktu č. 14", "https://cdn.alza.cz/Foto/14", null, "Produkt 14", 18168.03m },
                    { new Guid("41df05bc-171c-4788-8eef-b36e03802785"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2963), "Popis k produktu č. 15", "https://cdn.alza.cz/Foto/15", null, "Produkt 15", 90167.46m },
                    { new Guid("039659c0-ccca-42d2-aaba-f45895e510b3"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2972), "Popis k produktu č. 16", "https://cdn.alza.cz/Foto/16", null, "Produkt 16", 2021.96m },
                    { new Guid("bee184f4-ebd0-4be5-9de8-cbe74cf65758"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3006), "Popis k produktu č. 17", "https://cdn.alza.cz/Foto/17", null, "Produkt 17", 81959.5m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Description", "ImgUri", "Modified", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("c8da26c9-0ae5-40ba-9262-f83033d5fd60"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3014), "Popis k produktu č. 18", "https://cdn.alza.cz/Foto/18", null, "Produkt 18", 68259.24m },
                    { new Guid("f89cfc68-03d9-4f0c-8e05-f6c1b752ced2"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3020), "Popis k produktu č. 19", "https://cdn.alza.cz/Foto/19", null, "Produkt 19", 38910.3m },
                    { new Guid("f8d5da1c-ae35-4c2f-8b31-8e8296618129"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3027), "Popis k produktu č. 20", "https://cdn.alza.cz/Foto/20", null, "Produkt 20", 52370.34m },
                    { new Guid("ec91b5fb-3f39-41bc-be78-cfb4e560b43a"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3034), "Popis k produktu č. 21", "https://cdn.alza.cz/Foto/21", null, "Produkt 21", 85846.5m },
                    { new Guid("85e3cf3d-87d8-4525-a268-ad8c9a860c1a"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3040), "Popis k produktu č. 22", "https://cdn.alza.cz/Foto/22", null, "Produkt 22", 52973.07m },
                    { new Guid("515abff6-9473-41dc-99cc-7131a3fc474d"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3046), "Popis k produktu č. 23", "https://cdn.alza.cz/Foto/23", null, "Produkt 23", 669.51m },
                    { new Guid("88859109-ee16-4c6d-899f-9f9194e34f6c"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(2950), "Popis k produktu č. 13", "https://cdn.alza.cz/Foto/13", null, "Produkt 13", 50693.05m },
                    { new Guid("c679b254-02eb-407e-b679-2baadb185523"), new DateTime(2020, 11, 14, 19, 47, 57, 334, DateTimeKind.Local).AddTicks(3237), "Popis k produktu č. 50", "https://cdn.alza.cz/Foto/50", null, "Produkt 50", 51899.2m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
