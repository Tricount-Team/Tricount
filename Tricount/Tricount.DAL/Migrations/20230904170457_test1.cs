using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)   
        {
            migrationBuilder.DropIndex(
                name: "IX_Groups_Slug",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Slug",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(5356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "9b318554-35a3-4829-a35a-d58a4809eca0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5891bd94-af98-4043-995a-c353c0b6bac3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(1966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(2310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5a3797fb-808b-4b40-ae2a-32f1d731c057",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "1458ff93-c3f1-453e-83fe-7047598220a9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(8423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 302, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(8737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 302, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0bb8fe8a-74b8-4e6d-83a1-d26752237105",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "150a67fe-8f61-44fb-997d-218669674acc");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 300, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(1134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 300, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0dbbaf8b-6429-4209-a185-7d038f4be550",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bc53fa06-b482-470f-b47c-f267ea8f71d8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(4582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 301, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(4881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 301, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "expenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "b619e2b4-4685-49d1-9ab6-1bdc8f34786d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f57653ca-e723-441b-8d4f-ac0c5e1e6be7");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Slug",
                table: "Groups",
                column: "Slug",
                unique: true,
                filter: "[Slug] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Slug",
                table: "AspNetUsers",
                column: "Slug",
                unique: true,
                filter: "[Slug] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Groups_Slug",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Slug",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(7495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(8184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5891bd94-af98-4043-995a-c353c0b6bac3",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "9b318554-35a3-4829-a35a-d58a4809eca0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(1381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Invites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 303, DateTimeKind.Local).AddTicks(1991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 506, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "1458ff93-c3f1-453e-83fe-7047598220a9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5a3797fb-808b-4b40-ae2a-32f1d731c057");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 302, DateTimeKind.Local).AddTicks(4888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Groups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 302, DateTimeKind.Local).AddTicks(5477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "150a67fe-8f61-44fb-997d-218669674acc",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0bb8fe8a-74b8-4e6d-83a1-d26752237105");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 300, DateTimeKind.Local).AddTicks(7825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 300, DateTimeKind.Local).AddTicks(8784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bc53fa06-b482-470f-b47c-f267ea8f71d8",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0dbbaf8b-6429-4209-a185-7d038f4be550");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 301, DateTimeKind.Local).AddTicks(7814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "expenseDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 3, 22, 7, 45, 301, DateTimeKind.Local).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 4, 20, 4, 57, 505, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "expenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f57653ca-e723-441b-8d4f-ac0c5e1e6be7",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "b619e2b4-4685-49d1-9ab6-1bdc8f34786d");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Slug",
                table: "Groups",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Slug",
                table: "AspNetUsers",
                column: "Slug",
                unique: true);
        }
    }
}
