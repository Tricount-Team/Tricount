using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class modifiedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_DebtorId",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Expenses_ExpenseId",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "ExpenseId",
                table: "Payments",
                newName: "ExpenseDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_ExpenseId",
                table: "Payments",
                newName: "IX_Payments_ExpenseDetailId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a8242577-4c74-472f-8e6d-e2104fe7e707",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f01ce1a3-7944-470b-a46e-d4c4a1dbe62f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d2495301-b97c-4ca6-bb1b-929fb5e59cc9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "194833f6-9882-461c-9adc-997c74356b0a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(1955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(2072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7b67b8b3-6633-4a8a-b7f2-ab13a9b61d07",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "b257b2df-0d91-47fd-99b1-589f20a6fb86");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmount",
                table: "Expenses",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsFinished",
                table: "Expenses",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "68cf8103-07aa-4ca2-89e4-a3d999348749",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a3f70a96-b2b6-48ac-8f49-3583285c00b5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.AlterColumn<bool>(
                name: "IsPaid",
                table: "ExpenseDetails",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "DebtorId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(195));

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
                defaultValue: "c94358cd-d144-4bad-b5e2-cff27fce81da",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "3ec5cb8d-829b-4ab2-85bc-d15e5ed1c9cd");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_DebtorId",
                table: "ExpenseDetails",
                column: "DebtorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_ExpenseDetails_ExpenseDetailId",
                table: "Payments",
                column: "ExpenseDetailId",
                principalTable: "ExpenseDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_DebtorId",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_ExpenseDetails_ExpenseDetailId",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "ExpenseDetailId",
                table: "Payments",
                newName: "ExpenseId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_ExpenseDetailId",
                table: "Payments",
                newName: "IX_Payments_ExpenseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f01ce1a3-7944-470b-a46e-d4c4a1dbe62f",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a8242577-4c74-472f-8e6d-e2104fe7e707");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(3969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "194833f6-9882-461c-9adc-997c74356b0a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d2495301-b97c-4ca6-bb1b-929fb5e59cc9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 56, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "b257b2df-0d91-47fd-99b1-589f20a6fb86",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7b67b8b3-6633-4a8a-b7f2-ab13a9b61d07");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmount",
                table: "Expenses",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsFinished",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a3f70a96-b2b6-48ac-8f49-3583285c00b5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "68cf8103-07aa-4ca2-89e4-a3d999348749");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(78),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.AlterColumn<bool>(
                name: "IsPaid",
                table: "ExpenseDetails",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "DebtorId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 1, 18, 24, 38, 55, DateTimeKind.Local).AddTicks(9759));

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
                defaultValue: "3ec5cb8d-829b-4ab2-85bc-d15e5ed1c9cd",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "c94358cd-d144-4bad-b5e2-cff27fce81da");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_DebtorId",
                table: "ExpenseDetails",
                column: "DebtorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Expenses_ExpenseId",
                table: "Payments",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
