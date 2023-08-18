using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changeUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TCNO",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TCNO",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f4ffa2e2-aff3-4cc1-91f6-2da6075e14ea"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("dc2769cd-642d-4c73-9139-48865cd0e43c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(2931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(3034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("a60b73f2-ef3d-4605-91f5-6ac005bedcc9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e0e5fa55-99bd-4e12-8b8b-5614a731e55d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 803, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 803, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("53c3b876-152d-42b2-8fd8-8c9aa0ed0306"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f2085946-337b-4314-b522-0b66746bf024"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("91f472b8-f6de-418c-8b75-b28711a6b7ae"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("8d39ce9d-452d-4293-b410-bcf6e7e7202e"));

            migrationBuilder.AddColumn<string>(
                name: "Iban",
                table: "AspNetUsers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Iban",
                table: "AspNetUsers",
                column: "Iban",
                unique: true,
                filter: "[Iban] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Iban",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Iban",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(9606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(9729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("dc2769cd-642d-4c73-9139-48865cd0e43c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f4ffa2e2-aff3-4cc1-91f6-2da6075e14ea"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(7086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(7213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e0e5fa55-99bd-4e12-8b8b-5614a731e55d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("a60b73f2-ef3d-4605-91f5-6ac005bedcc9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 803, DateTimeKind.Local).AddTicks(3644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 803, DateTimeKind.Local).AddTicks(3785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 287, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f2085946-337b-4314-b522-0b66746bf024"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("53c3b876-152d-42b2-8fd8-8c9aa0ed0306"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 20, 1, 54, 804, DateTimeKind.Local).AddTicks(982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 20, 31, 12, 288, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("8d39ce9d-452d-4293-b410-bcf6e7e7202e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("91f472b8-f6de-418c-8b75-b28711a6b7ae"));

            migrationBuilder.AddColumn<string>(
                name: "TCNO",
                table: "AspNetUsers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TCNO",
                table: "AspNetUsers",
                column: "TCNO",
                unique: true,
                filter: "[TCNO] IS NOT NULL");
        }
    }
}
