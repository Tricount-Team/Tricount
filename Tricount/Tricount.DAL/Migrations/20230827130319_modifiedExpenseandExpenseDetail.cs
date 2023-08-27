using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class modifiedExpenseandExpenseDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_UserId",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_Groups_GroupId",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_AspNetUsers_UserId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_ExpenseId_GroupId_UserId",
                table: "ExpenseDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_GroupId",
                table: "ExpenseDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_UserId",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Invites");

            migrationBuilder.DropColumn(
                name: "ExpenseId",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExpenseDetails");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Expenses",
                newName: "PayerId");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Expenses",
                newName: "TotalAmount");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                newName: "IX_Expenses_PayerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f01ce1a3-7944-470b-a46e-d4c4a1dbe62f",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "40a542cf-7c34-4b2d-a1bb-dbd81559db34");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(3969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "194833f6-9882-461c-9adc-997c74356b0a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0b13b0f9-499e-4cdb-ad9e-6d0af74bee02");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "b257b2df-0d91-47fd-99b1-589f20a6fb86",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "2e6a1bbb-0860-46b1-abe5-324f1261c2c1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a3f70a96-b2b6-48ac-8f49-3583285c00b5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4b3e0cb1-8231-4403-a06d-8ec039e206e1");

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(78),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "3ec5cb8d-829b-4ab2-85bc-d15e5ed1c9cd",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7a7c5198-c6b9-42bb-8ada-8bdbd035fccb");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "ExpenseDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "DebtorId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ExpenseExpenseDetail",
                columns: table => new
                {
                    ExpenseDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpensesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseExpenseDetail", x => new { x.ExpenseDetailsId, x.ExpensesId });
                    table.ForeignKey(
                        name: "FK_ExpenseExpenseDetail_ExpenseDetails_ExpenseDetailsId",
                        column: x => x.ExpenseDetailsId,
                        principalTable: "ExpenseDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpenseExpenseDetail_Expenses_ExpensesId",
                        column: x => x.ExpensesId,
                        principalTable: "Expenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_DebtorId",
                table: "ExpenseDetails",
                column: "DebtorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseExpenseDetail_ExpensesId",
                table: "ExpenseExpenseDetail",
                column: "ExpensesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_DebtorId",
                table: "ExpenseDetails",
                column: "DebtorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_AspNetUsers_PayerId",
                table: "Expenses",
                column: "PayerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_DebtorId",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_AspNetUsers_PayerId",
                table: "Expenses");

            migrationBuilder.DropTable(
                name: "ExpenseExpenseDetail");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_DebtorId",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "DebtorId",
                table: "ExpenseDetails");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Expenses",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "PayerId",
                table: "Expenses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_PayerId",
                table: "Expenses",
                newName: "IX_Expenses_UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "40a542cf-7c34-4b2d-a1bb-dbd81559db34",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f01ce1a3-7944-470b-a46e-d4c4a1dbe62f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0b13b0f9-499e-4cdb-ad9e-6d0af74bee02",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "194833f6-9882-461c-9adc-997c74356b0a");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Invites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(7084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "2e6a1bbb-0860-46b1-abe5-324f1261c2c1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "b257b2df-0d91-47fd-99b1-589f20a6fb86");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 31, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4b3e0cb1-8231-4403-a06d-8ec039e206e1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a3f70a96-b2b6-48ac-8f49-3583285c00b5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 27, 16, 3, 19, 32, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7a7c5198-c6b9-42bb-8ada-8bdbd035fccb",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "3ec5cb8d-829b-4ab2-85bc-d15e5ed1c9cd");

            migrationBuilder.AddColumn<string>(
                name: "ExpenseId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroupId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_ExpenseId_GroupId_UserId",
                table: "ExpenseDetails",
                columns: new[] { "ExpenseId", "GroupId", "UserId" },
                unique: true,
                filter: "[ExpenseId] IS NOT NULL AND [GroupId] IS NOT NULL AND [UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_GroupId",
                table: "ExpenseDetails",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_UserId",
                table: "ExpenseDetails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_UserId",
                table: "ExpenseDetails",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId",
                table: "ExpenseDetails",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_Groups_GroupId",
                table: "ExpenseDetails",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_AspNetUsers_UserId",
                table: "Expenses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
