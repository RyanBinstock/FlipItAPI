using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlipIt.API.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Data_Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("10f3cc43-ddae-4a36-8590-66f90060220b"),
                column: "Details",
                value: "1tb m.2 NVMe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: new Guid("10f3cc43-ddae-4a36-8590-66f90060220b"),
                column: "Details",
                value: "1tb m.2 NVMw");
        }
    }
}
