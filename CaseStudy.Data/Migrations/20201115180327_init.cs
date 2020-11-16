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
                    { new Guid("ae96089b-861c-456e-8dea-f400206c55e5"), new DateTime(2020, 11, 15, 19, 3, 27, 224, DateTimeKind.Local).AddTicks(7945), "Popis k produktu č. 01", "https://cdn.alza.cz/Foto/01", null, "Produkt 01", 35099.74m },
                    { new Guid("0fc10d5f-5411-4fed-a236-865e428a9633"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8916), "Popis k produktu č. 28", "https://cdn.alza.cz/Foto/28", null, "Produkt 28", 3662.9m },
                    { new Guid("8e024027-5568-411d-936e-77776f7e9cd3"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8926), "Popis k produktu č. 29", "https://cdn.alza.cz/Foto/29", null, "Produkt 29", 49101.86m },
                    { new Guid("7fddc55c-0419-48ad-9dda-0637e2419c03"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8936), "Popis k produktu č. 30", "https://cdn.alza.cz/Foto/30", null, "Produkt 30", 754.48m },
                    { new Guid("dc3a5509-4029-4797-bf00-9cd83ebf3c39"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8950), "Popis k produktu č. 31", "https://cdn.alza.cz/Foto/31", null, "Produkt 31", 47151.69m },
                    { new Guid("548fda38-8035-4f68-9cd2-51c8e92e9568"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8959), "Popis k produktu č. 32", "https://cdn.alza.cz/Foto/32", null, "Produkt 32", 15662.59m },
                    { new Guid("1e05d426-1968-4306-8f11-137121d00c32"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8969), "Popis k produktu č. 33", "https://cdn.alza.cz/Foto/33", null, "Produkt 33", 23099.12m },
                    { new Guid("ccd60290-9912-4cbc-8593-fc216ee47ee9"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8983), "Popis k produktu č. 34", "https://cdn.alza.cz/Foto/34", null, "Produkt 34", 57111.71m },
                    { new Guid("7a3a0c65-9168-4336-90a3-ce3d2bd18c93"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8994), "Popis k produktu č. 35", "https://cdn.alza.cz/Foto/35", null, "Produkt 35", 60610.07m },
                    { new Guid("c146c8e9-a0f6-407f-84e4-7a916a62c8a8"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9005), "Popis k produktu č. 36", "https://cdn.alza.cz/Foto/36", null, "Produkt 36", 22099.67m },
                    { new Guid("2c8bd5bb-fece-4971-9a3a-dad255d6e17b"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9015), "Popis k produktu č. 37", "https://cdn.alza.cz/Foto/37", null, "Produkt 37", 11602.97m },
                    { new Guid("5ba87061-8cf7-4518-8b2e-059a6e1bbb37"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9025), "Popis k produktu č. 38", "https://cdn.alza.cz/Foto/38", null, "Produkt 38", 46492.11m },
                    { new Guid("c9720edf-5ce1-4822-aafb-25f88aa81260"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9040), "Popis k produktu č. 39", "https://cdn.alza.cz/Foto/39", null, "Produkt 39", 16926.86m },
                    { new Guid("a38e4a4d-bdb2-4295-bdba-f1ef6d5b3d7c"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9050), "Popis k produktu č. 40", "https://cdn.alza.cz/Foto/40", null, "Produkt 40", 53794.11m },
                    { new Guid("2a265986-0eba-478c-b062-f9e669471f38"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9060), "Popis k produktu č. 41", "https://cdn.alza.cz/Foto/41", null, "Produkt 41", 94000.87m },
                    { new Guid("7ac50599-3db6-4d18-8708-4d46ff252271"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9071), "Popis k produktu č. 42", "https://cdn.alza.cz/Foto/42", null, "Produkt 42", 45248.97m },
                    { new Guid("019f7156-8955-464d-9b64-c99c99099d33"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9083), "Popis k produktu č. 43", "https://cdn.alza.cz/Foto/43", null, "Produkt 43", 23582.46m },
                    { new Guid("13b5d9af-cbc8-4985-bec8-2f31a8396015"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9093), "Popis k produktu č. 44", "https://cdn.alza.cz/Foto/44", null, "Produkt 44", 52929.85m },
                    { new Guid("39f94f8d-a557-456e-9780-063ff86bc824"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9104), "Popis k produktu č. 45", "https://cdn.alza.cz/Foto/45", null, "Produkt 45", 70794.1m },
                    { new Guid("b1cf0749-a6c8-443b-925a-be3dd92e9888"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9114), "Popis k produktu č. 46", "https://cdn.alza.cz/Foto/46", null, "Produkt 46", 43659.17m },
                    { new Guid("c6780881-13c3-429a-bd33-81fd8e5986cc"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9126), "Popis k produktu č. 47", "https://cdn.alza.cz/Foto/47", null, "Produkt 47", 31837.15m },
                    { new Guid("8b5e05f6-5837-4072-95f6-fd6a5c9d2e97"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9135), "Popis k produktu č. 48", "https://cdn.alza.cz/Foto/48", null, "Produkt 48", 26659.91m },
                    { new Guid("6d8403ec-b5f2-4b34-b940-6a84055021f4"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8903), "Popis k produktu č. 27", "https://cdn.alza.cz/Foto/27", null, "Produkt 27", 383.99m },
                    { new Guid("1e094d42-8030-497d-a2ed-e22b9b212de2"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8845), "Popis k produktu č. 26", "https://cdn.alza.cz/Foto/26", null, "Produkt 26", 86255.74m },
                    { new Guid("55a857a8-fad5-4710-b27a-404127ee7ac2"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8835), "Popis k produktu č. 25", "https://cdn.alza.cz/Foto/25", null, "Produkt 25", 52309.79m },
                    { new Guid("683b9c1d-d93a-43d2-8b7c-1c9700566069"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8825), "Popis k produktu č. 24", "https://cdn.alza.cz/Foto/24", null, "Produkt 24", 92876.67m },
                    { new Guid("92060adc-a1a9-48e6-bfa3-5f3561ec5038"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8333), "Popis k produktu č. 02", "https://cdn.alza.cz/Foto/02", null, "Produkt 02", 65912.18m },
                    { new Guid("580e3d21-03c1-4066-8620-f526ab1dc319"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8489), "Popis k produktu č. 03", "https://cdn.alza.cz/Foto/03", null, "Produkt 03", 28853.94m },
                    { new Guid("1bfca8d3-982e-4082-9d71-ed50f2b786fb"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8578), "Popis k produktu č. 04", "https://cdn.alza.cz/Foto/04", null, "Produkt 04", 33009.97m },
                    { new Guid("65d6c8e8-44e5-4d99-9c59-3b57e2ca2538"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8591), "Popis k produktu č. 05", "https://cdn.alza.cz/Foto/05", null, "Produkt 05", 46399.45m },
                    { new Guid("756998b5-a6f7-48d4-aa3e-c1bc15ebc9bd"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8611), "Popis k produktu č. 06", "https://cdn.alza.cz/Foto/06", null, "Produkt 06", 99253.36m },
                    { new Guid("f89ab00c-74e3-4a3e-aafe-dadfb8cd5a5c"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8637), "Popis k produktu č. 07", "https://cdn.alza.cz/Foto/07", null, "Produkt 07", 86025.27m },
                    { new Guid("91ccde14-0397-44a6-bf07-feb44a96c750"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8649), "Popis k produktu č. 08", "https://cdn.alza.cz/Foto/08", null, "Produkt 08", 80637.27m },
                    { new Guid("38b8d62d-8b70-4f2a-a43e-095d8fac008b"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8661), "Popis k produktu č. 09", "https://cdn.alza.cz/Foto/09", null, "Produkt 09", 91526.92m },
                    { new Guid("6f972903-fcef-4d85-bda1-02e3305507d9"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8676), "Popis k produktu č. 10", "https://cdn.alza.cz/Foto/10", null, "Produkt 10", 55788.49m },
                    { new Guid("8dc81956-e1ee-4c9a-8f3b-fd12be811f63"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8689), "Popis k produktu č. 11", "https://cdn.alza.cz/Foto/11", null, "Produkt 11", 44979.29m },
                    { new Guid("0e8cd973-6134-4319-8d54-3fc319f513a9"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9144), "Popis k produktu č. 49", "https://cdn.alza.cz/Foto/49", null, "Produkt 49", 7153.18m },
                    { new Guid("380d5716-d39e-4294-b20f-45deb8b6db3f"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8700), "Popis k produktu č. 12", "https://cdn.alza.cz/Foto/12", null, "Produkt 12", 81102.73m },
                    { new Guid("87bcd017-4d9d-4690-a03d-584f91d5b8a7"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8721), "Popis k produktu č. 14", "https://cdn.alza.cz/Foto/14", null, "Produkt 14", 84459.28m },
                    { new Guid("99c4dd87-ddd9-41ec-a315-c8b1f92673d9"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8735), "Popis k produktu č. 15", "https://cdn.alza.cz/Foto/15", null, "Produkt 15", 44924.54m },
                    { new Guid("ecb8c574-76dd-4858-8f0d-71e70d135be9"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8744), "Popis k produktu č. 16", "https://cdn.alza.cz/Foto/16", null, "Produkt 16", 29797m },
                    { new Guid("40093b65-45e6-47a3-aed6-b6c37b30a0dd"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8754), "Popis k produktu č. 17", "https://cdn.alza.cz/Foto/17", null, "Produkt 17", 28066.87m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Description", "ImgUri", "Modified", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("e0581e04-55bd-4271-95a8-156eddc435b8"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8766), "Popis k produktu č. 18", "https://cdn.alza.cz/Foto/18", null, "Produkt 18", 48061.81m },
                    { new Guid("0c48df1f-b5fe-427b-b68e-093ebf43c5ff"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8775), "Popis k produktu č. 19", "https://cdn.alza.cz/Foto/19", null, "Produkt 19", 53821.3m },
                    { new Guid("4b99c164-b2e3-4ea4-98b4-2b16c784d646"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8784), "Popis k produktu č. 20", "https://cdn.alza.cz/Foto/20", null, "Produkt 20", 77551.07m },
                    { new Guid("bd135a97-4a4a-4b94-aad5-c5689e49d3df"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8793), "Popis k produktu č. 21", "https://cdn.alza.cz/Foto/21", null, "Produkt 21", 88149.62m },
                    { new Guid("31239b9e-0ee2-4af7-bc48-a95c870ed8ab"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8803), "Popis k produktu č. 22", "https://cdn.alza.cz/Foto/22", null, "Produkt 22", 80002.34m },
                    { new Guid("11bf6a8f-5612-48f8-9a87-a464c505fb69"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8816), "Popis k produktu č. 23", "https://cdn.alza.cz/Foto/23", null, "Produkt 23", 18195.79m },
                    { new Guid("bb3b6094-3cbf-47d2-9ceb-4700c7de82d2"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(8711), "Popis k produktu č. 13", "https://cdn.alza.cz/Foto/13", null, "Produkt 13", 8212.36m },
                    { new Guid("f0a3190c-81df-43a1-8407-162b17b278ac"), new DateTime(2020, 11, 15, 19, 3, 27, 228, DateTimeKind.Local).AddTicks(9223), "Popis k produktu č. 50", "https://cdn.alza.cz/Foto/50", null, "Produkt 50", 97871.07m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
