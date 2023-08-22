using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class tricount5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(3732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(4042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 493, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b6ae05b6-e191-4295-bfae-5f6cd2748487"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("6d8765a0-682d-49b2-8f5c-f942ee045e69"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3a359128-f02d-4380-84cc-6a036581895e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("1d4a41ba-a01a-439b-b134-2001aca3b047"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(2314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 491, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(2623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 491, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("6012664c-d36b-4bda-870a-2e4c20f003ed"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("022c3305-5abc-4828-8d53-23a80a24e261"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(5986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(6298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3022f5bc-c5a0-4b96-95a9-ae4cacc08454"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("9b453f12-343b-4d4c-805c-84027d15b033"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(9508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 493, DateTimeKind.Local).AddTicks(81),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("6d8765a0-682d-49b2-8f5c-f942ee045e69"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b6ae05b6-e191-4295-bfae-5f6cd2748487"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(6552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(6798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 63, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("1d4a41ba-a01a-439b-b134-2001aca3b047"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3a359128-f02d-4380-84cc-6a036581895e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 491, DateTimeKind.Local).AddTicks(8264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 491, DateTimeKind.Local).AddTicks(8567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("022c3305-5abc-4828-8d53-23a80a24e261"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("6012664c-d36b-4bda-870a-2e4c20f003ed"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(2086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ExpenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 21, 23, 18, 29, 492, DateTimeKind.Local).AddTicks(2397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 21, 23, 41, 42, 62, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ExpenseDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("9b453f12-343b-4d4c-805c-84027d15b033"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3022f5bc-c5a0-4b96-95a9-ae4cacc08454"));
        }
    }
}
