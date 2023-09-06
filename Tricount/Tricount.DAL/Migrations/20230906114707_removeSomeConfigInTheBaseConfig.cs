using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class removeSomeConfigInTheBaseConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "00044a7e-8478-4855-9dd0-ad5d30696555",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4652b5f4-2732-4e57-bb8a-ff9f77f5f0b9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bf32b7d0-465e-4c6d-aa3f-299fab069f48",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "67fb65e8-7e74-4e70-a06b-2bd2c03e78e0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a02b5132-67e5-4a09-a289-7731e7c6ef02",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4731dc1c-6d44-4ee8-ad80-b43293af6af8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ed95136c-1cbb-4c61-bd68-b633fe53df74",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "93875c3a-f6e3-442d-8dc9-3459c4ba5dc1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ebfaf653-63e7-49bc-8aba-cb00fa5340ea",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "56d2f0fd-f8b0-402c-925a-cb0e922cd8e9");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4652b5f4-2732-4e57-bb8a-ff9f77f5f0b9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "00044a7e-8478-4855-9dd0-ad5d30696555");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "67fb65e8-7e74-4e70-a06b-2bd2c03e78e0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bf32b7d0-465e-4c6d-aa3f-299fab069f48");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(2),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4731dc1c-6d44-4ee8-ad80-b43293af6af8",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a02b5132-67e5-4a09-a289-7731e7c6ef02");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "93875c3a-f6e3-442d-8dc9-3459c4ba5dc1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ed95136c-1cbb-4c61-bd68-b633fe53df74");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(8065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "56d2f0fd-f8b0-402c-925a-cb0e922cd8e9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ebfaf653-63e7-49bc-8aba-cb00fa5340ea");
        }
    }
}
