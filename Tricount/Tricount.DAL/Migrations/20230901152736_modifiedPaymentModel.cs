using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class modifiedPaymentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Groups_GroupId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_GroupId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Payments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7e797df2-acf1-45ad-b7af-73921cc9ca22",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a8242577-4c74-472f-8e6d-e2104fe7e707");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(8918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(9130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "52d96332-dbec-486e-bae0-d337f81df7c6",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d2495301-b97c-4ca6-bb1b-929fb5e59cc9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "683d4daf-920a-42c8-bb88-6d53e212570c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7b67b8b3-6633-4a8a-b7f2-ab13a9b61d07");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "1bcb0c24-596e-4943-9e0e-f01696cd19f0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "68cf8103-07aa-4ca2-89e4-a3d999348749");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(3919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(4026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4290d005-34df-415e-b6a3-2c9434f9d3a4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "c94358cd-d144-4bad-b5e2-cff27fce81da");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a8242577-4c74-472f-8e6d-e2104fe7e707",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7e797df2-acf1-45ad-b7af-73921cc9ca22");

            migrationBuilder.AddColumn<string>(
                name: "GroupId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d2495301-b97c-4ca6-bb1b-929fb5e59cc9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "52d96332-dbec-486e-bae0-d337f81df7c6");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(1955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(2072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7b67b8b3-6633-4a8a-b7f2-ab13a9b61d07",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "683d4daf-920a-42c8-bb88-6d53e212570c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "68cf8103-07aa-4ca2-89e4-a3d999348749",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "1bcb0c24-596e-4943-9e0e-f01696cd19f0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "c94358cd-d144-4bad-b5e2-cff27fce81da",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4290d005-34df-415e-b6a3-2c9434f9d3a4");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GroupId",
                table: "Payments",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Groups_GroupId",
                table: "Payments",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
