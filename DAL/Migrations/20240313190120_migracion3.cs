﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isPaid",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderPositions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPositions_ProductId",
                table: "OrderPositions",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Products_ProductId",
                table: "OrderPositions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Products_ProductId",
                table: "OrderPositions");

            migrationBuilder.DropIndex(
                name: "IX_OrderPositions_ProductId",
                table: "OrderPositions");

            migrationBuilder.DropColumn(
                name: "isPaid",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderPositions");
        }
    }
}
