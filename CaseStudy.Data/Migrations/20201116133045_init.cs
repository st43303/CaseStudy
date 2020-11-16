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
                    { new Guid("cb2221b4-f761-4228-b354-a6fb53ab2be0"), new DateTime(2020, 11, 16, 14, 30, 44, 261, DateTimeKind.Local).AddTicks(8864), "The description of product 01", "https://cdn.alza.cz/Foto/01", null, "Product 01", 51221.56m },
                    { new Guid("b95c6661-23e8-4799-98b3-bca6a82b7791"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8209), "The description of product 28", "https://cdn.alza.cz/Foto/28", null, "Product 28", 39954.35m },
                    { new Guid("94f22ae2-e614-4b29-bf2f-bf3b3c2ab952"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8215), "The description of product 29", "https://cdn.alza.cz/Foto/29", null, "Product 29", 26809.13m },
                    { new Guid("e739097c-ee32-45b4-96e8-8854b3f55fbd"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8221), "The description of product 30", "https://cdn.alza.cz/Foto/30", null, "Product 30", 21481.23m },
                    { new Guid("7d9b7ce2-87d1-4a7b-9386-7b581ebe9e6d"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8227), "The description of product 31", "https://cdn.alza.cz/Foto/31", null, "Product 31", 10252.2m },
                    { new Guid("cdae1971-e111-424f-9371-11ee148e188d"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8235), "The description of product 32", "https://cdn.alza.cz/Foto/32", null, "Product 32", 54380.63m },
                    { new Guid("195d1f6c-2edc-46df-9b7f-fe9790a09b62"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8241), "The description of product 33", "https://cdn.alza.cz/Foto/33", null, "Product 33", 57670.33m },
                    { new Guid("a098b197-887e-45e7-a81e-845b093d7e25"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8289), "The description of product 34", "https://cdn.alza.cz/Foto/34", null, "Product 34", 39886.25m },
                    { new Guid("ff74cfe6-95db-41bf-8c66-0c399d387c16"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8295), "The description of product 35", "https://cdn.alza.cz/Foto/35", null, "Product 35", 41872.33m },
                    { new Guid("23c448e2-6b97-45aa-804a-f18afe087b7d"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8301), "The description of product 36", "https://cdn.alza.cz/Foto/36", null, "Product 36", 86565.33m },
                    { new Guid("c68e3ad9-9333-4f29-a26e-b4a936c2d67f"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8307), "The description of product 37", "https://cdn.alza.cz/Foto/37", null, "Product 37", 65620.22m },
                    { new Guid("61ed40d6-d664-4d3b-a128-8dcc171e644f"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8313), "The description of product 38", "https://cdn.alza.cz/Foto/38", null, "Product 38", 34363.36m },
                    { new Guid("4ab815af-cee7-461f-bd54-cfc57a7c85a1"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8320), "The description of product 39", "https://cdn.alza.cz/Foto/39", null, "Product 39", 22550.16m },
                    { new Guid("6e89381e-765a-48f0-8bb6-0823302f2740"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8329), "The description of product 40", "https://cdn.alza.cz/Foto/40", null, "Product 40", 57489.36m },
                    { new Guid("a3e537f8-433f-4ee2-a4ff-3a8cee2a8d21"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8335), "The description of product 41", "https://cdn.alza.cz/Foto/41", null, "Product 41", 72401.78m },
                    { new Guid("22a1bf10-a094-4c24-aa6b-65d1cd07aa04"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8341), "The description of product 42", "https://cdn.alza.cz/Foto/42", null, "Product 42", 92021.63m },
                    { new Guid("4efc7f03-083b-441c-bfdb-714f65df2180"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8347), "The description of product 43", "https://cdn.alza.cz/Foto/43", null, "Product 43", 52021.6m },
                    { new Guid("d16c7f2f-67e0-4635-a4d3-2abe85c347dd"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8354), "The description of product 44", "https://cdn.alza.cz/Foto/44", null, "Product 44", 78567.54m },
                    { new Guid("055a44da-792c-42cd-9069-5b4f56479447"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8360), "The description of product 45", "https://cdn.alza.cz/Foto/45", null, "Product 45", 69898.22m },
                    { new Guid("82cd7071-e7c0-46bb-9c72-1cae29d69b2c"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8366), "The description of product 46", "https://cdn.alza.cz/Foto/46", null, "Product 46", 31761.29m },
                    { new Guid("3be77be4-bd3c-4bcd-ac55-d43f2b13fb3c"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8373), "The description of product 47", "https://cdn.alza.cz/Foto/47", null, "Product 47", 7187.54m },
                    { new Guid("559dfd96-f1e5-4485-8e85-36a51f08a042"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8382), "The description of product 48", "https://cdn.alza.cz/Foto/48", null, "Product 48", 21141.6m },
                    { new Guid("7d2c66c0-53f9-40c9-91da-0dd7314477f7"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8202), "The description of product 27", "https://cdn.alza.cz/Foto/27", null, "Product 27", 49229.43m },
                    { new Guid("fb2e2743-229f-4966-83c5-ae62c1212b27"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8196), "The description of product 26", "https://cdn.alza.cz/Foto/26", null, "Product 26", 76283.36m },
                    { new Guid("859d0c66-0c59-4a84-91c3-14bbd2b168b6"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8190), "The description of product 25", "https://cdn.alza.cz/Foto/25", null, "Product 25", 11088.67m },
                    { new Guid("ee5a456b-e82c-4314-92f4-8c04ccf4a0a0"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8183), "The description of product 24", "https://cdn.alza.cz/Foto/24", null, "Product 24", 99182.22m },
                    { new Guid("2356ba20-6d8e-444f-8625-062165c6956f"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(7833), "The description of product 02", "https://cdn.alza.cz/Foto/02", null, "Product 02", 85859.71m },
                    { new Guid("57f47587-2d03-4b4c-a463-d277de0abaa3"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(7949), "The description of product 03", "https://cdn.alza.cz/Foto/03", null, "Product 03", 85293.5m },
                    { new Guid("a5f05e43-04dd-4d00-9bde-40e48d607640"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(7961), "The description of product 04", "https://cdn.alza.cz/Foto/04", null, "Product 04", 6140.19m },
                    { new Guid("7c4494b8-dc6e-4780-8427-4eee093aa1c2"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(7967), "The description of product 05", "https://cdn.alza.cz/Foto/05", null, "Product 05", 44674.33m },
                    { new Guid("942abd0e-34fe-483d-a093-accd8c189272"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(7979), "The description of product 06", "https://cdn.alza.cz/Foto/06", null, "Product 06", 7103.46m },
                    { new Guid("a986af61-7164-40a3-a845-e82dc347c32a"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(7986), "The description of product 07", "https://cdn.alza.cz/Foto/07", null, "Product 07", 34883.71m },
                    { new Guid("4f6437d2-9c86-4602-8299-e1cab435ee20"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8007), "The description of product 08", "https://cdn.alza.cz/Foto/08", null, "Product 08", 81248.83m },
                    { new Guid("91c03e1f-3951-42b7-8ce0-39beee0763c8"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8014), "The description of product 09", "https://cdn.alza.cz/Foto/09", null, "Product 09", 98240.26m },
                    { new Guid("f03245cb-dfc8-46ac-b647-c9edda223272"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8023), "The description of product 10", "https://cdn.alza.cz/Foto/10", null, "Product 10", 43335.78m },
                    { new Guid("e748adc3-90d2-4aef-9036-4d387f1dd843"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8030), "The description of product 11", "https://cdn.alza.cz/Foto/11", null, "Product 11", 52767.85m },
                    { new Guid("d15caa39-ce75-4dcd-8f82-b28e36dfe5e4"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8388), "The description of product 49", "https://cdn.alza.cz/Foto/49", null, "Product 49", 79471.55m },
                    { new Guid("b4dc2274-32e3-415b-b36f-6b105079c9f4"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8099), "The description of product 12", "https://cdn.alza.cz/Foto/12", null, "Product 12", 29367.98m },
                    { new Guid("847ab9b1-be17-4ba4-9dd0-edfad7394516"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8112), "The description of product 14", "https://cdn.alza.cz/Foto/14", null, "Product 14", 50027.44m },
                    { new Guid("bfe07b09-e343-47fa-ac03-fe5deac8a244"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8119), "The description of product 15", "https://cdn.alza.cz/Foto/15", null, "Product 15", 97186.66m },
                    { new Guid("73f25a32-6ff4-462f-91b0-dcde40da688b"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8128), "The description of product 16", "https://cdn.alza.cz/Foto/16", null, "Product 16", 54623.56m },
                    { new Guid("5516ba7c-f99e-4c4e-aca2-78e147e89c47"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8134), "The description of product 17", "https://cdn.alza.cz/Foto/17", null, "Product 17", 20838.61m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Description", "ImgUri", "Modified", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("e7feb64b-1861-4c47-8089-b0ac58f8c8ab"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8143), "The description of product 18", "https://cdn.alza.cz/Foto/18", null, "Product 18", 6257.81m },
                    { new Guid("713b7b55-a7b7-47f5-b311-0ba907030351"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8149), "The description of product 19", "https://cdn.alza.cz/Foto/19", null, "Product 19", 58833.05m },
                    { new Guid("4d10ad35-714f-42ba-a645-9a7166e93b96"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8156), "The description of product 20", "https://cdn.alza.cz/Foto/20", null, "Product 20", 19348.98m },
                    { new Guid("8b45cb7a-15f4-4fae-9804-80920ce90419"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8162), "The description of product 21", "https://cdn.alza.cz/Foto/21", null, "Product 21", 58885.12m },
                    { new Guid("43156284-4785-409e-83b7-b33951a474a6"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8168), "The description of product 22", "https://cdn.alza.cz/Foto/22", null, "Product 22", 33662.44m },
                    { new Guid("cf06c36e-6dd3-451a-a9bf-082ca6bb31c3"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8174), "The description of product 23", "https://cdn.alza.cz/Foto/23", null, "Product 23", 96359.5m },
                    { new Guid("7eb1b076-c36c-4325-9fdd-2fc69b1d24d8"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8106), "The description of product 13", "https://cdn.alza.cz/Foto/13", null, "Product 13", 99585.17m },
                    { new Guid("6418c027-f62d-496a-b675-2e8272ce0490"), new DateTime(2020, 11, 16, 14, 30, 44, 264, DateTimeKind.Local).AddTicks(8394), "The description of product 50", "https://cdn.alza.cz/Foto/50", null, "Product 50", 45084.58m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
