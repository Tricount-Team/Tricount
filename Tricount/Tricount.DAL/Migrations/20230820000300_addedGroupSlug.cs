using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addedGroupSlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(6725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(6861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3505e9fb-5691-491e-be64-b74597f160bf"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("7b153268-d979-4515-8540-18d8198fe97e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(4627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(4754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("bb87d3e4-8026-4506-97d1-e00fab55ab27"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("51371b54-0e2b-4881-b0f1-028c2426e585"));

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 476, DateTimeKind.Local).AddTicks(8587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 476, DateTimeKind.Local).AddTicks(8761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("19bab5e5-701b-4427-a4e4-87a0a957f296"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("7fb6b71f-a948-4cab-95e7-c2f508d437c2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(1618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(1784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("373cd26e-5936-4fa8-b58d-ba86045b0984"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e09fa919-4767-4396-b4c2-aac8fd520984"));

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Slug",
                table: "Groups",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Groups_Slug",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Groups");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7b153268-d979-4515-8540-18d8198fe97e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3505e9fb-5691-491e-be64-b74597f160bf"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("51371b54-0e2b-4881-b0f1-028c2426e585"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("bb87d3e4-8026-4506-97d1-e00fab55ab27"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 476, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 476, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7fb6b71f-a948-4cab-95e7-c2f508d437c2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("19bab5e5-701b-4427-a4e4-87a0a957f296"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 3, 3, 0, 477, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e09fa919-4767-4396-b4c2-aac8fd520984"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("373cd26e-5936-4fa8-b58d-ba86045b0984"));
        }
    }
}
