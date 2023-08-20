using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addSlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7b153268-d979-4515-8540-18d8198fe97e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f4ffa2e2-aff3-4cc1-91f6-2da6075e14ea"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("51371b54-0e2b-4881-b0f1-028c2426e585"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("a60b73f2-ef3d-4605-91f5-6ac005bedcc9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7fb6b71f-a948-4cab-95e7-c2f508d437c2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("53c3b876-152d-42b2-8fd8-8c9aa0ed0306"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e09fa919-4767-4396-b4c2-aac8fd520984"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("91f472b8-f6de-418c-8b75-b28711a6b7ae"));

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Slug",
                table: "AspNetUsers",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Slug",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f4ffa2e2-aff3-4cc1-91f6-2da6075e14ea"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("7b153268-d979-4515-8540-18d8198fe97e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(2931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(3034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("a60b73f2-ef3d-4605-91f5-6ac005bedcc9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("51371b54-0e2b-4881-b0f1-028c2426e585"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("53c3b876-152d-42b2-8fd8-8c9aa0ed0306"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("7fb6b71f-a948-4cab-95e7-c2f508d437c2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 20, 2, 34, 35, 182, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("91f472b8-f6de-418c-8b75-b28711a6b7ae"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e09fa919-4767-4396-b4c2-aac8fd520984"));
        }
    }
}
