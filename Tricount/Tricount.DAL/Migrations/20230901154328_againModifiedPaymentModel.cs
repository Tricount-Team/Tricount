using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class againModifiedPaymentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_UserId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Payments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4652b5f4-2732-4e57-bb8a-ff9f77f5f0b9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7e797df2-acf1-45ad-b7af-73921cc9ca22");

            migrationBuilder.AddColumn<string>(
                name: "DebtorId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "67fb65e8-7e74-4e70-a06b-2bd2c03e78e0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "52d96332-dbec-486e-bae0-d337f81df7c6");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(2),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4731dc1c-6d44-4ee8-ad80-b43293af6af8",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "683d4daf-920a-42c8-bb88-6d53e212570c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "93875c3a-f6e3-442d-8dc9-3459c4ba5dc1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "1bcb0c24-596e-4943-9e0e-f01696cd19f0");

            migrationBuilder.AddColumn<string>(
                name: "PaymentId",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(8065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "ExpenseDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "56d2f0fd-f8b0-402c-925a-cb0e922cd8e9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4290d005-34df-415e-b6a3-2c9434f9d3a4");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "ExpenseDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_DebtorId",
                table: "Payments",
                column: "DebtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_PaymentId",
                table: "Expenses",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Payments_PaymentId",
                table: "Expenses",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_DebtorId",
                table: "Payments",
                column: "DebtorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Payments_PaymentId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_DebtorId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_DebtorId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_PaymentId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "DebtorId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "ExpenseDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 531, DateTimeKind.Local).AddTicks(1308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7e797df2-acf1-45ad-b7af-73921cc9ca22",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4652b5f4-2732-4e57-bb8a-ff9f77f5f0b9");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(8918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(9130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "52d96332-dbec-486e-bae0-d337f81df7c6",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "67fb65e8-7e74-4e70-a06b-2bd2c03e78e0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 357, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "683d4daf-920a-42c8-bb88-6d53e212570c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4731dc1c-6d44-4ee8-ad80-b43293af6af8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(1875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "1bcb0c24-596e-4943-9e0e-f01696cd19f0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "93875c3a-f6e3-442d-8dc9-3459c4ba5dc1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(3919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 27, 36, 530, DateTimeKind.Local).AddTicks(4026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 43, 28, 356, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "ExpenseDetails",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4290d005-34df-415e-b6a3-2c9434f9d3a4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "56d2f0fd-f8b0-402c-925a-cb0e922cd8e9");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
