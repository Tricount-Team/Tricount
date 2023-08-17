using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addExtendDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetail_AspNetUsers_UserId1",
                table: "ExpenseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetail_Expenses_ExpenseId",
                table: "ExpenseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetail_Groups_GroupId",
                table: "ExpenseDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpenseDetail",
                table: "ExpenseDetail");

            migrationBuilder.RenameTable(
                name: "ExpenseDetail",
                newName: "ExpenseDetails");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetail_UserId1",
                table: "ExpenseDetails",
                newName: "IX_ExpenseDetails_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetail_Id",
                table: "ExpenseDetails",
                newName: "IX_ExpenseDetails_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetail_GroupId",
                table: "ExpenseDetails",
                newName: "IX_ExpenseDetails_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetail_ExpenseId_GroupId_UserId",
                table: "ExpenseDetails",
                newName: "IX_ExpenseDetails_ExpenseId_GroupId_UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(7337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("d41e2913-2ede-40d4-97d2-79df759bfdab"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e767f023-feb3-4fde-9133-a9e67544c12b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(5581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(5704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("c8a5c573-f959-4e32-881f-d72bbae58c0d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e2b25a8e-c3ea-4b28-8621-c0bdb6910017"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("43b98ffc-7d17-4892-ae44-8764c225ff9d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("1dfebb6c-0981-40c6-97cf-f8f88189c530"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(2829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(2976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("bc1fda91-40d3-458f-a573-60beed1723ca"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("84f27b1a-eba9-493e-8d02-0f6a4e7fe703"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpenseDetails",
                table: "ExpenseDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_UserId1",
                table: "ExpenseDetails",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId",
                table: "ExpenseDetails",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_Groups_GroupId",
                table: "ExpenseDetails",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_UserId1",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_Groups_GroupId",
                table: "ExpenseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpenseDetails",
                table: "ExpenseDetails");

            migrationBuilder.RenameTable(
                name: "ExpenseDetails",
                newName: "ExpenseDetail");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetails_UserId1",
                table: "ExpenseDetail",
                newName: "IX_ExpenseDetail_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetails_Id",
                table: "ExpenseDetail",
                newName: "IX_ExpenseDetail_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetails_GroupId",
                table: "ExpenseDetail",
                newName: "IX_ExpenseDetail_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ExpenseDetails_ExpenseId_GroupId_UserId",
                table: "ExpenseDetail",
                newName: "IX_ExpenseDetail_ExpenseId_GroupId_UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(9261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e767f023-feb3-4fde-9133-a9e67544c12b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("d41e2913-2ede-40d4-97d2-79df759bfdab"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(7386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(7500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e2b25a8e-c3ea-4b28-8621-c0bdb6910017"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("c8a5c573-f959-4e32-881f-d72bbae58c0d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(2117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(2273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("1dfebb6c-0981-40c6-97cf-f8f88189c530"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("43b98ffc-7d17-4892-ae44-8764c225ff9d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(4432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 17, 12, 43, 26, 560, DateTimeKind.Local).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 17, 12, 47, 48, 300, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("84f27b1a-eba9-493e-8d02-0f6a4e7fe703"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("bc1fda91-40d3-458f-a573-60beed1723ca"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpenseDetail",
                table: "ExpenseDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetail_AspNetUsers_UserId1",
                table: "ExpenseDetail",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetail_Expenses_ExpenseId",
                table: "ExpenseDetail",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetail_Groups_GroupId",
                table: "ExpenseDetail",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
