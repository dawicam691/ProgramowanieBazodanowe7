using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Products_ProductId",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Products_ProductId1",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Users_UserId",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Users_UserId1",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Orders_OrderId",
                table: "OrderPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Orders_OrderId1",
                table: "OrderPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductGroups_GroupId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductGroups_ProductGroupId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserGroups_GroupId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserGroups_UserGroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserGroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderPositions_OrderId1",
                table: "OrderPositions");

            migrationBuilder.DropIndex(
                name: "IX_BasketPositions_ProductId1",
                table: "BasketPositions");

            migrationBuilder.DropIndex(
                name: "IX_BasketPositions_UserId1",
                table: "BasketPositions");

            migrationBuilder.DropColumn(
                name: "UserGroupId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProductGroupId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "OrderPositions");

            migrationBuilder.DropColumn(
                name: "OrderId2",
                table: "OrderPositions");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "BasketPositions");

            migrationBuilder.DropColumn(
                name: "ProductId2",
                table: "BasketPositions");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "BasketPositions");

            migrationBuilder.DropColumn(
                name: "UserId2",
                table: "BasketPositions");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Products_ProductId",
                table: "BasketPositions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Users_UserId",
                table: "BasketPositions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Orders_OrderId",
                table: "OrderPositions",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductGroups_GroupId",
                table: "Products",
                column: "GroupId",
                principalTable: "ProductGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserGroups_GroupId",
                table: "Users",
                column: "GroupId",
                principalTable: "UserGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Products_ProductId",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Users_UserId",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Orders_OrderId",
                table: "OrderPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductGroups_GroupId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserGroups_GroupId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserGroupId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductGroupId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId2",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId1",
                table: "OrderPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId2",
                table: "OrderPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "BasketPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId2",
                table: "BasketPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "BasketPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId2",
                table: "BasketPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserGroupId",
                table: "Users",
                column: "UserGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPositions_OrderId1",
                table: "OrderPositions",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_BasketPositions_ProductId1",
                table: "BasketPositions",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_BasketPositions_UserId1",
                table: "BasketPositions",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Products_ProductId",
                table: "BasketPositions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Products_ProductId1",
                table: "BasketPositions",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Users_UserId",
                table: "BasketPositions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Users_UserId1",
                table: "BasketPositions",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Orders_OrderId",
                table: "OrderPositions",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Orders_OrderId1",
                table: "OrderPositions",
                column: "OrderId1",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductGroups_GroupId",
                table: "Products",
                column: "GroupId",
                principalTable: "ProductGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductGroups_ProductGroupId",
                table: "Products",
                column: "ProductGroupId",
                principalTable: "ProductGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserGroups_GroupId",
                table: "Users",
                column: "GroupId",
                principalTable: "UserGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserGroups_UserGroupId",
                table: "Users",
                column: "UserGroupId",
                principalTable: "UserGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
