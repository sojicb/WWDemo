﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WWDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Index_ProductsSerialNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_SerialNumber",
                table: "Products",
                column: "SerialNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_SerialNumber",
                table: "Products");
        }
    }
}
