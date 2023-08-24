using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addedSenderIdInInvite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_UserId1",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId1",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_Groups_GroupId1",
                table: "ExpenseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_AspNetUsers_UserId1",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Invites_AspNetUsers_UserId",
                table: "Invites");

            migrationBuilder.DropForeignKey(
                name: "FK_Invites_Groups_GroupId",
                table: "Invites");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_UserId1",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Expenses_ExpenseId1",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Groups_GroupId1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ExpenseId1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_GroupId1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_UserId1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_UserId1",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_ExpenseId1",
                table: "ExpenseDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_GroupId1",
                table: "ExpenseDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_UserId1",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "ExpenseId1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "GroupId1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpenseId1",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "GroupId1",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "ExpenseDetails");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.AlterColumn<string>(
                name: "GroupId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "40a542cf-7c34-4b2d-a1bb-dbd81559db34",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ee77495f-cd8e-44e7-b4fd-9d8934b484a0");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<string>(
                name: "GroupId",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0b13b0f9-499e-4cdb-ad9e-6d0af74bee02",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "11022cc6-4833-4967-8015-fd10e3a108bc");

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Invites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(7084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "2e6a1bbb-0860-46b1-abe5-324f1261c2c1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "900aa5bc-9c95-45a0-a18c-2617509a0811");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "4b3e0cb1-8231-4403-a06d-8ec039e206e1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "478020ec-77a2-46d2-9b5b-8faf1ab3ab5b");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.AlterColumn<string>(
                name: "GroupId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7a7c5198-c6b9-42bb-8ada-8bdbd035fccb",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "77393434-e400-4012-ad72-146df218bfb1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ExpenseId",
                table: "Payments",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GroupId",
                table: "Payments",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Invites_AspNetUsers_UserId",
                table: "Invites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invites_Groups_GroupId",
                table: "Invites",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments",
                column: "UserId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Groups_GroupId",
                table: "Payments",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Invites_AspNetUsers_UserId",
                table: "Invites");

            migrationBuilder.DropForeignKey(
                name: "FK_Invites_Groups_GroupId",
                table: "Invites");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Expenses_ExpenseId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Groups_GroupId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ExpenseId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_GroupId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_UserId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_GroupId",
                table: "ExpenseDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_UserId",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Invites");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(2372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ExpenseId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(2497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 621, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ee77495f-cd8e-44e7-b4fd-9d8934b484a0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "40a542cf-7c34-4b2d-a1bb-dbd81559db34");

            migrationBuilder.AddColumn<string>(
                name: "ExpenseId1",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroupId1",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.AlterColumn<string>(
                name: "GroupId",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 565, DateTimeKind.Local).AddTicks(412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "11022cc6-4833-4967-8015-fd10e3a108bc",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0b13b0f9-499e-4cdb-ad9e-6d0af74bee02");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(8427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(8533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "900aa5bc-9c95-45a0-a18c-2617509a0811",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "2e6a1bbb-0860-46b1-abe5-324f1261c2c1");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(3850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(4004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "478020ec-77a2-46d2-9b5b-8faf1ab3ab5b",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "4b3e0cb1-8231-4403-a06d-8ec039e206e1");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(6000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ExpenseId",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 0, 56, 55, 564, DateTimeKind.Local).AddTicks(6128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 12, 34, 26, 620, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "77393434-e400-4012-ad72-146df218bfb1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7a7c5198-c6b9-42bb-8ada-8bdbd035fccb");

            migrationBuilder.AddColumn<string>(
                name: "ExpenseId1",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroupId1",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ExpenseId1",
                table: "Payments",
                column: "ExpenseId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GroupId1",
                table: "Payments",
                column: "GroupId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId1",
                table: "Payments",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId1",
                table: "Expenses",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_ExpenseId1",
                table: "ExpenseDetails",
                column: "ExpenseId1");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_GroupId1",
                table: "ExpenseDetails",
                column: "GroupId1");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_UserId1",
                table: "ExpenseDetails",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_AspNetUsers_UserId1",
                table: "ExpenseDetails",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId1",
                table: "ExpenseDetails",
                column: "ExpenseId1",
                principalTable: "Expenses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_Groups_GroupId1",
                table: "ExpenseDetails",
                column: "GroupId1",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_AspNetUsers_UserId1",
                table: "Expenses",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invites_AspNetUsers_UserId",
                table: "Invites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invites_Groups_GroupId",
                table: "Invites",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_UserId1",
                table: "Payments",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Expenses_ExpenseId1",
                table: "Payments",
                column: "ExpenseId1",
                principalTable: "Expenses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Groups_GroupId1",
                table: "Payments",
                column: "GroupId1",
                principalTable: "Groups",
                principalColumn: "Id");
        }
    }
}
