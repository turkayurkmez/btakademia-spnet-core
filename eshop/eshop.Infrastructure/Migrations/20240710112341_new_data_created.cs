using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class new_data_created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bilgisayar ve Tablet" },
                    { 2, "Ses Sistemleri" },
                    { 3, "Monitör" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "IsActive", "Name", "Price", "Status", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9172), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "Dell XPS 15", 96000m, null, null, null },
                    { 2, 1, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9211), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "Lenovo", 86000m, null, null, null },
                    { 3, 1, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9214), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "Asus", 50000m, null, null, null },
                    { 4, 2, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9218), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "Ses -A", 96000m, null, null, null },
                    { 5, 2, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9221), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "Ses-B", 86000m, null, null, null },
                    { 6, 2, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9225), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "Ses-C", 50000m, null, null, null },
                    { 7, 3, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9229), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "M -A", 96000m, null, null, null },
                    { 8, 3, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9233), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "M-B", 86000m, null, null, null },
                    { 9, 3, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9237), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "M-C", 50000m, null, null, null },
                    { 10, 1, new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9207), "Açıklama", "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg", true, "MacBook Pro M2", 96000m, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
