using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class Fixer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemOrderd_ProductName",
                table: "OrderItems",
                newName: "ItemOrdered_ProductName");

            migrationBuilder.RenameColumn(
                name: "ItemOrderd_ProductItemId",
                table: "OrderItems",
                newName: "ItemOrdered_ProductItemId");

            migrationBuilder.RenameColumn(
                name: "ItemOrderd_PictureUrl",
                table: "OrderItems",
                newName: "ItemOrdered_PictureUrl");

            migrationBuilder.AlterColumn<long>(
                name: "OrderDate",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemOrdered_ProductName",
                table: "OrderItems",
                newName: "ItemOrderd_ProductName");

            migrationBuilder.RenameColumn(
                name: "ItemOrdered_ProductItemId",
                table: "OrderItems",
                newName: "ItemOrderd_ProductItemId");

            migrationBuilder.RenameColumn(
                name: "ItemOrdered_PictureUrl",
                table: "OrderItems",
                newName: "ItemOrderd_PictureUrl");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OrderDate",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");
        }
    }
}
