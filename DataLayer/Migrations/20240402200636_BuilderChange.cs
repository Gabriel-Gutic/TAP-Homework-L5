using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class BuilderChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("af2cd36c-bb43-4e8c-b5c5-62f9c6450634"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("e6b39b49-53db-4eef-9e36-f04d06b27456"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("eb5e3a9c-d6e3-4574-954c-45d9dd6b8131"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("3f688795-7822-4ea4-9a6e-91c09a78430f"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("562b9a3c-e17e-46c5-b42f-cb3eae881d44"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("6dfe9925-d76a-4fa1-a60a-82b480d9f472"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("8b22c387-1424-45c3-b494-e4f21c51c10f"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("8d939c48-bfe5-44c2-a6ef-5cd7e90b7513"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("d4741f93-f028-4112-b4f6-9cceafbcd3da"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("e317b8e6-b738-4bc6-96ca-c569df50a8db"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("f03ac834-0d4f-40f5-9c3d-a3077cb422e9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("07ae8913-ec0c-4110-aa7c-9638d0059e13"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("34550853-e2df-4378-8879-e86abda5b2c8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9df41939-93ea-42c4-b4a3-4ed6c941c5aa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fd9b6c99-63a9-4a13-bad6-26f6091bf362"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("4a0036f1-5e27-4662-b379-c92eea215542"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("8fd24f07-5581-4406-bdbc-b211025b2141"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("d96730bf-6374-4a82-9bae-69d706fafbcc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("19d51914-ac74-4b94-803c-8506511038d2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("33b791ed-0085-4016-9c0b-0f068e663326"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f1fa59fa-a7cf-4e05-9031-cad1063a3caf"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("2498bde0-7373-4978-9df7-40d937157ddb"), 30, "Ana" },
                    { new Guid("cbd81efe-94d7-4015-97d1-e0f489c95f45"), 21, "Gabi" },
                    { new Guid("eb1ea9f2-aac2-411d-8558-a59964f68002"), 20, "Maria" }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("6fcec86f-115c-4d2d-a609-c58303e2f44b"), "Mozzarella, Branza", "Margherita", 24f },
                    { new Guid("b6ff7fa5-de07-4fb1-86e5-a0bd5bce11cf"), "Mozzarella, Salam, Sunca, Sos", "Capricioasa", 34f },
                    { new Guid("cb44436a-4daa-4bb4-b3fa-3c82a15363ab"), "Mozzarella, Salam Picant, Sos Picant", "Diavola", 32f },
                    { new Guid("dd22afa8-d31b-466e-80ae-767f6f5bc3b8"), "Mozzarella, Salam, Cabanos, Sos", "Salami", 28f }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Devices", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("6d35550a-4038-4977-b311-344d9b4cc87c"), "Computer, Laptop, Printer", new Guid("cbd81efe-94d7-4015-97d1-e0f489c95f45") },
                    { new Guid("a214bbc1-d5aa-4613-a0fc-59b05ae6a6fe"), "Computer", new Guid("2498bde0-7373-4978-9df7-40d937157ddb") },
                    { new Guid("d2e90ff1-7f68-411c-b5f4-f33866ba236f"), "Laptop, Printer", new Guid("eb1ea9f2-aac2-411d-8558-a59964f68002") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateTime", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("493b8291-cebf-4a1b-983a-cad4420a2341"), new DateTime(2024, 4, 2, 23, 6, 36, 248, DateTimeKind.Local).AddTicks(3862), new Guid("cbd81efe-94d7-4015-97d1-e0f489c95f45") },
                    { new Guid("50ac8ee4-37d4-4b01-a031-6a1bc0ec83f7"), new DateTime(2024, 4, 2, 23, 6, 36, 248, DateTimeKind.Local).AddTicks(3927), new Guid("cbd81efe-94d7-4015-97d1-e0f489c95f45") },
                    { new Guid("ba42d62b-b5a1-461c-a215-aa805463fc2a"), new DateTime(2024, 4, 2, 23, 6, 36, 248, DateTimeKind.Local).AddTicks(3925), new Guid("2498bde0-7373-4978-9df7-40d937157ddb") },
                    { new Guid("e905b0d2-9080-48cd-9f8d-7cd42231993e"), new DateTime(2024, 4, 2, 23, 6, 36, 248, DateTimeKind.Local).AddTicks(3922), new Guid("eb1ea9f2-aac2-411d-8558-a59964f68002") }
                });

            migrationBuilder.InsertData(
                table: "OrderPizza",
                columns: new[] { "Id", "OrderId", "PizzaId" },
                values: new object[,]
                {
                    { new Guid("20fef68b-bf30-4799-af5b-570bb5017e7d"), new Guid("493b8291-cebf-4a1b-983a-cad4420a2341"), new Guid("dd22afa8-d31b-466e-80ae-767f6f5bc3b8") },
                    { new Guid("2b35e444-e2bc-49ea-878e-67a9c25a77a8"), new Guid("50ac8ee4-37d4-4b01-a031-6a1bc0ec83f7"), new Guid("cb44436a-4daa-4bb4-b3fa-3c82a15363ab") },
                    { new Guid("3b9d9ed8-2c2a-4f30-9f7b-d730420d7e69"), new Guid("e905b0d2-9080-48cd-9f8d-7cd42231993e"), new Guid("b6ff7fa5-de07-4fb1-86e5-a0bd5bce11cf") },
                    { new Guid("6c53ecc2-f12b-4cf5-8852-10543ea94e78"), new Guid("50ac8ee4-37d4-4b01-a031-6a1bc0ec83f7"), new Guid("6fcec86f-115c-4d2d-a609-c58303e2f44b") },
                    { new Guid("73d87cee-5fec-4933-ae71-43211f13baaa"), new Guid("ba42d62b-b5a1-461c-a215-aa805463fc2a"), new Guid("6fcec86f-115c-4d2d-a609-c58303e2f44b") },
                    { new Guid("7dc06549-91fa-47d9-94be-da6f939d86f0"), new Guid("ba42d62b-b5a1-461c-a215-aa805463fc2a"), new Guid("b6ff7fa5-de07-4fb1-86e5-a0bd5bce11cf") },
                    { new Guid("848d7d6f-eb61-42cb-9ed8-51df2398c650"), new Guid("493b8291-cebf-4a1b-983a-cad4420a2341"), new Guid("cb44436a-4daa-4bb4-b3fa-3c82a15363ab") },
                    { new Guid("8dcb2b5f-eed8-41fb-ae64-ae038996dcfe"), new Guid("50ac8ee4-37d4-4b01-a031-6a1bc0ec83f7"), new Guid("b6ff7fa5-de07-4fb1-86e5-a0bd5bce11cf") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("6d35550a-4038-4977-b311-344d9b4cc87c"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("a214bbc1-d5aa-4613-a0fc-59b05ae6a6fe"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("d2e90ff1-7f68-411c-b5f4-f33866ba236f"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("20fef68b-bf30-4799-af5b-570bb5017e7d"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("2b35e444-e2bc-49ea-878e-67a9c25a77a8"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("3b9d9ed8-2c2a-4f30-9f7b-d730420d7e69"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("6c53ecc2-f12b-4cf5-8852-10543ea94e78"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("73d87cee-5fec-4933-ae71-43211f13baaa"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("7dc06549-91fa-47d9-94be-da6f939d86f0"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("848d7d6f-eb61-42cb-9ed8-51df2398c650"));

            migrationBuilder.DeleteData(
                table: "OrderPizza",
                keyColumn: "Id",
                keyValue: new Guid("8dcb2b5f-eed8-41fb-ae64-ae038996dcfe"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("493b8291-cebf-4a1b-983a-cad4420a2341"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("50ac8ee4-37d4-4b01-a031-6a1bc0ec83f7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba42d62b-b5a1-461c-a215-aa805463fc2a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e905b0d2-9080-48cd-9f8d-7cd42231993e"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("6fcec86f-115c-4d2d-a609-c58303e2f44b"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("b6ff7fa5-de07-4fb1-86e5-a0bd5bce11cf"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("cb44436a-4daa-4bb4-b3fa-3c82a15363ab"));

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: new Guid("dd22afa8-d31b-466e-80ae-767f6f5bc3b8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2498bde0-7373-4978-9df7-40d937157ddb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cbd81efe-94d7-4015-97d1-e0f489c95f45"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("eb1ea9f2-aac2-411d-8558-a59964f68002"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("19d51914-ac74-4b94-803c-8506511038d2"), 30, "Ana" },
                    { new Guid("33b791ed-0085-4016-9c0b-0f068e663326"), 21, "Gabi" },
                    { new Guid("f1fa59fa-a7cf-4e05-9031-cad1063a3caf"), 20, "Maria" }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4a0036f1-5e27-4662-b379-c92eea215542"), "Mozzarella, Salam, Cabanos, Sos", "Salami", 28f },
                    { new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653"), "Mozzarella, Salam, Sunca, Sos", "Capricioasa", 34f },
                    { new Guid("8fd24f07-5581-4406-bdbc-b211025b2141"), "Mozzarella, Branza", "Margherita", 24f },
                    { new Guid("d96730bf-6374-4a82-9bae-69d706fafbcc"), "Mozzarella, Salam Picant, Sos Picant", "Diavola", 32f }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Devices", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("af2cd36c-bb43-4e8c-b5c5-62f9c6450634"), "Computer", new Guid("19d51914-ac74-4b94-803c-8506511038d2") },
                    { new Guid("e6b39b49-53db-4eef-9e36-f04d06b27456"), "Computer, Laptop, Printer", new Guid("33b791ed-0085-4016-9c0b-0f068e663326") },
                    { new Guid("eb5e3a9c-d6e3-4574-954c-45d9dd6b8131"), "Laptop, Printer", new Guid("f1fa59fa-a7cf-4e05-9031-cad1063a3caf") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateTime", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("07ae8913-ec0c-4110-aa7c-9638d0059e13"), new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6087), new Guid("f1fa59fa-a7cf-4e05-9031-cad1063a3caf") },
                    { new Guid("34550853-e2df-4378-8879-e86abda5b2c8"), new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6092), new Guid("33b791ed-0085-4016-9c0b-0f068e663326") },
                    { new Guid("9df41939-93ea-42c4-b4a3-4ed6c941c5aa"), new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6027), new Guid("33b791ed-0085-4016-9c0b-0f068e663326") },
                    { new Guid("fd9b6c99-63a9-4a13-bad6-26f6091bf362"), new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6090), new Guid("19d51914-ac74-4b94-803c-8506511038d2") }
                });

            migrationBuilder.InsertData(
                table: "OrderPizza",
                columns: new[] { "Id", "OrderId", "PizzaId" },
                values: new object[,]
                {
                    { new Guid("3f688795-7822-4ea4-9a6e-91c09a78430f"), new Guid("34550853-e2df-4378-8879-e86abda5b2c8"), new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653") },
                    { new Guid("562b9a3c-e17e-46c5-b42f-cb3eae881d44"), new Guid("9df41939-93ea-42c4-b4a3-4ed6c941c5aa"), new Guid("d96730bf-6374-4a82-9bae-69d706fafbcc") },
                    { new Guid("6dfe9925-d76a-4fa1-a60a-82b480d9f472"), new Guid("07ae8913-ec0c-4110-aa7c-9638d0059e13"), new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653") },
                    { new Guid("8b22c387-1424-45c3-b494-e4f21c51c10f"), new Guid("34550853-e2df-4378-8879-e86abda5b2c8"), new Guid("d96730bf-6374-4a82-9bae-69d706fafbcc") },
                    { new Guid("8d939c48-bfe5-44c2-a6ef-5cd7e90b7513"), new Guid("9df41939-93ea-42c4-b4a3-4ed6c941c5aa"), new Guid("4a0036f1-5e27-4662-b379-c92eea215542") },
                    { new Guid("d4741f93-f028-4112-b4f6-9cceafbcd3da"), new Guid("34550853-e2df-4378-8879-e86abda5b2c8"), new Guid("8fd24f07-5581-4406-bdbc-b211025b2141") },
                    { new Guid("e317b8e6-b738-4bc6-96ca-c569df50a8db"), new Guid("fd9b6c99-63a9-4a13-bad6-26f6091bf362"), new Guid("8fd24f07-5581-4406-bdbc-b211025b2141") },
                    { new Guid("f03ac834-0d4f-40f5-9c3d-a3077cb422e9"), new Guid("fd9b6c99-63a9-4a13-bad6-26f6091bf362"), new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653") }
                });
        }
    }
}
