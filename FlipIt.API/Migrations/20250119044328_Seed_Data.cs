using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlipIt.API.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Builds",
                columns: new[] { "Id", "BuildCost", "DateListed", "DateSold", "Description" },
                values: new object[] { new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), null, null, null, "First PC Flip!" });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "PartName" },
                values: new object[,]
                {
                    { new Guid("11ecb302-3f35-44f0-9d32-4a63d421e8dc"), "COOLER" },
                    { new Guid("27f66724-0cc1-4968-b3ee-6f4460c1ab33"), "PSU" },
                    { new Guid("7c67d165-1560-4684-8adc-3f9e2cd5513a"), "GPU" },
                    { new Guid("90a8eadc-a3a7-4f0e-8d6f-7f930fb9dc20"), "MOBO" },
                    { new Guid("d3287e4b-189a-4f55-b5c5-898434ec2ffc"), "CPU" },
                    { new Guid("d8d59d14-4275-4af8-92dc-ce88c8c94fa6"), "MEMORY" },
                    { new Guid("dcff96b3-a4c6-4454-8d89-dbb70562d712"), "STORAGE" },
                    { new Guid("ecef90a2-ab8b-48f4-a379-430f1cad9140"), "CASE" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "VendorName" },
                values: new object[,]
                {
                    { new Guid("2d818341-be49-420b-ae01-d375c460756a"), "Amazon" },
                    { new Guid("674a8043-7458-4670-83cb-441bfcd422dd"), "Jawa" },
                    { new Guid("8926f78c-1a13-4824-9cd8-a7185ccbecac"), "AliExpress" },
                    { new Guid("9f7ff836-eca7-4f46-a42e-e9ae833cd2a1"), "Other" },
                    { new Guid("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4"), "Newegg" },
                    { new Guid("d4bd707d-6d07-4730-a179-69256c819983"), "Facebook MarketPlace" },
                    { new Guid("e846cc3a-3bf1-4c2d-b139-5b54f9834aec"), "eBay" }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "BuildId", "Details", "Name", "PartId", "Price", "VendorId" },
                values: new object[,]
                {
                    { new Guid("10f3cc43-ddae-4a36-8590-66f90060220b"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "1tb m.2 NVMe", "ORICO SSD", new Guid("dcff96b3-a4c6-4454-8d89-dbb70562d712"), 67.790000000000006, new Guid("2d818341-be49-420b-ae01-d375c460756a") },
                    { new Guid("3b59a8da-9bb1-4c1b-915d-576ed0cc99db"), null, "", "GIGABYTE GTX 1070ti", new Guid("7c67d165-1560-4684-8adc-3f9e2cd5513a"), 90.0, new Guid("d4bd707d-6d07-4730-a179-69256c819983") },
                    { new Guid("3eadd160-85a8-47ba-808d-a333ded9ec83"), null, "", "Ryzen 5 2600", new Guid("d3287e4b-189a-4f55-b5c5-898434ec2ffc"), 15.0, new Guid("d4bd707d-6d07-4730-a179-69256c819983") },
                    { new Guid("4fc141cf-9afe-4d60-9231-36600895c0ec"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "mATX", "DIYPC ARGB-Q3", new Guid("ecef90a2-ab8b-48f4-a379-430f1cad9140"), 101.68000000000001, new Guid("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4") },
                    { new Guid("562bd3bc-043f-4505-be2f-aed42f4b47d9"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "8gb", "RADEON RX 580", new Guid("7c67d165-1560-4684-8adc-3f9e2cd5513a"), 60.0, new Guid("d4bd707d-6d07-4730-a179-69256c819983") },
                    { new Guid("5901e2cf-bf85-4b75-a9d2-6131139c3b5a"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "2x8gb DDR4 3200", "Team T-Force", new Guid("d8d59d14-4275-4af8-92dc-ce88c8c94fa6"), 45.149999999999999, new Guid("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4") },
                    { new Guid("70ceed4c-458a-447b-8b2f-ee5461cf61cd"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "700 watt 80+ Bronze", "Deep Cool DA700", new Guid("27f66724-0cc1-4968-b3ee-6f4460c1ab33"), 35.0, new Guid("d4bd707d-6d07-4730-a179-69256c819983") },
                    { new Guid("9fd43134-1966-4e2b-9f51-a23044f8edfd"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "", "MSI A530M-A PRO", new Guid("90a8eadc-a3a7-4f0e-8d6f-7f930fb9dc20"), 91.75, new Guid("e846cc3a-3bf1-4c2d-b139-5b54f9834aec") },
                    { new Guid("ade6e1e6-3a24-4803-b4dc-13dd43cc42cf"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "white rgb heatsink", "AIGO ICEPRO200", new Guid("11ecb302-3f35-44f0-9d32-4a63d421e8dc"), 16.379999999999999, new Guid("8926f78c-1a13-4824-9cd8-a7185ccbecac") },
                    { new Guid("bfb6188a-5dfa-473e-95c0-f523eea43e12"), new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"), "", "Ryzen 5 3600", new Guid("d3287e4b-189a-4f55-b5c5-898434ec2ffc"), 50.0, new Guid("d4bd707d-6d07-4730-a179-69256c819983") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("10f3cc43-ddae-4a36-8590-66f90060220b"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("3b59a8da-9bb1-4c1b-915d-576ed0cc99db"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("3eadd160-85a8-47ba-808d-a333ded9ec83"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("4fc141cf-9afe-4d60-9231-36600895c0ec"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("562bd3bc-043f-4505-be2f-aed42f4b47d9"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("5901e2cf-bf85-4b75-a9d2-6131139c3b5a"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("70ceed4c-458a-447b-8b2f-ee5461cf61cd"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("9fd43134-1966-4e2b-9f51-a23044f8edfd"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("ade6e1e6-3a24-4803-b4dc-13dd43cc42cf"));

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("bfb6188a-5dfa-473e-95c0-f523eea43e12"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("674a8043-7458-4670-83cb-441bfcd422dd"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("9f7ff836-eca7-4f46-a42e-e9ae833cd2a1"));

            migrationBuilder.DeleteData(
                table: "Builds",
                keyColumn: "Id",
                keyValue: new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("11ecb302-3f35-44f0-9d32-4a63d421e8dc"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("27f66724-0cc1-4968-b3ee-6f4460c1ab33"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("7c67d165-1560-4684-8adc-3f9e2cd5513a"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("90a8eadc-a3a7-4f0e-8d6f-7f930fb9dc20"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("d3287e4b-189a-4f55-b5c5-898434ec2ffc"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("d8d59d14-4275-4af8-92dc-ce88c8c94fa6"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("dcff96b3-a4c6-4454-8d89-dbb70562d712"));

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: new Guid("ecef90a2-ab8b-48f4-a379-430f1cad9140"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("2d818341-be49-420b-ae01-d375c460756a"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("8926f78c-1a13-4824-9cd8-a7185ccbecac"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("d4bd707d-6d07-4730-a179-69256c819983"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("e846cc3a-3bf1-4c2d-b139-5b54f9834aec"));
        }
    }
}
