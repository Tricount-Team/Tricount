using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class slug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Groups_Slug",
                table: "Groups");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(9930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 316, DateTimeKind.Local).AddTicks(73),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "555866ed-d441-4b21-b173-6afe283ad1d1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "e86254d6-55d0-4890-9519-3ff0f318eb12");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(5187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(5301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "da1edb69-5fe3-4295-bce9-9c0fd9e3e021",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bddc7f94-e632-4163-9faf-ab59f7507674");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "e6ff259d-a710-4d96-8093-65282242cb93",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "9a63d9d6-8fc5-44c6-9eff-26a916fd290d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(2567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(2716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "445050b7-667a-4cf7-a0a8-04bcef4cfb51",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "248cdfa3-47bc-4695-99d2-3bee01b79681");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(8773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(8909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 316, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "e86254d6-55d0-4890-9519-3ff0f318eb12",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "555866ed-d441-4b21-b173-6afe283ad1d1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(4332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(4430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bddc7f94-e632-4163-9faf-ab59f7507674",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "da1edb69-5fe3-4295-bce9-9c0fd9e3e021");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(43),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "9a63d9d6-8fc5-44c6-9eff-26a916fd290d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "e6ff259d-a710-4d96-8093-65282242cb93");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(2109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 14, 20, 21, 220, DateTimeKind.Local).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 14, 55, 54, 315, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "248cdfa3-47bc-4695-99d2-3bee01b79681",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "445050b7-667a-4cf7-a0a8-04bcef4cfb51");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Slug",
                table: "Groups",
                column: "Slug",
                unique: true);
        }
    }
}
