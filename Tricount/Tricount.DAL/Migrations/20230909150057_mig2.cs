using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(9631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 736, DateTimeKind.Local).AddTicks(71),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5e90e1b8-3a9a-423d-b42f-22d75e9eb495",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7dd898f2-e0e8-4664-941d-f90d85c2d353");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(5190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(5659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0526e679-2850-4256-b8e3-e407e185edc9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "8e7c39fd-33b3-4af6-a161-0f5d7c0cf4f1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(37),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "62e6f02c-02cb-4875-bc4c-f812a8da646a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d2a61063-b101-4c38-bb38-5ca5cd70e52d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(1002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 38, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(1480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 38, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "e01c08a8-df60-4b59-b8df-a2453ef4534a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "affdd87d-6ffd-4d4c-8292-b28d6c9d0ef3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(5428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(5831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "expenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0a33bcd9-162e-4d1e-aa94-4c22cd850981",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a9051fd1-7c77-4c56-b71e-71e5bbb1f049");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(4465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(4852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 736, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7dd898f2-e0e8-4664-941d-f90d85c2d353",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5e90e1b8-3a9a-423d-b42f-22d75e9eb495");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(1124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 40, DateTimeKind.Local).AddTicks(1477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "8e7c39fd-33b3-4af6-a161-0f5d7c0cf4f1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0526e679-2850-4256-b8e3-e407e185edc9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(7122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 735, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d2a61063-b101-4c38-bb38-5ca5cd70e52d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "62e6f02c-02cb-4875-bc4c-f812a8da646a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 38, DateTimeKind.Local).AddTicks(9541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 38, DateTimeKind.Local).AddTicks(9914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "affdd87d-6ffd-4d4c-8292-b28d6c9d0ef3",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "e01c08a8-df60-4b59-b8df-a2453ef4534a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(3460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 23, 47, 52, 39, DateTimeKind.Local).AddTicks(3787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 9, 18, 0, 57, 734, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "expenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a9051fd1-7c77-4c56-b71e-71e5bbb1f049",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0a33bcd9-162e-4d1e-aa94-4c22cd850981");
        }
    }
}
