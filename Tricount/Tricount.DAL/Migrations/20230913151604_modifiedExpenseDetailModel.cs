using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tricount.DAL.Migrations
{
    /// <inheritdoc />
    public partial class modifiedExpenseDetailModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseExpenseDetail");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "67a2264b-c353-4ec9-b0e9-14f7965dc184",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "00044a7e-8478-4855-9dd0-ad5d30696555");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a385851e-f3dc-4aaa-8179-2dae59d3d73a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bf32b7d0-465e-4c6d-aa3f-299fab069f48");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "48af55fb-3be6-4c9d-8b19-80fd0eb13664",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a02b5132-67e5-4a09-a289-7731e7c6ef02");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "227dbfd6-4315-4189-a3a1-790aea41d332",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ed95136c-1cbb-4c61-bd68-b633fe53df74");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d1aa4644-a610-45ca-86c2-261986c47ca6",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ebfaf653-63e7-49bc-8aba-cb00fa5340ea");

            migrationBuilder.AddColumn<string>(
                name: "ExpenseId",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_ExpenseId",
                table: "ExpenseDetails",
                column: "ExpenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId",
                table: "ExpenseDetails",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseDetails_Expenses_ExpenseId",
                table: "ExpenseDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseDetails_ExpenseId",
                table: "ExpenseDetails");

            migrationBuilder.DropColumn(
                name: "ExpenseId",
                table: "ExpenseDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "00044a7e-8478-4855-9dd0-ad5d30696555",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "67a2264b-c353-4ec9-b0e9-14f7965dc184");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bf32b7d0-465e-4c6d-aa3f-299fab069f48",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a385851e-f3dc-4aaa-8179-2dae59d3d73a");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a02b5132-67e5-4a09-a289-7731e7c6ef02",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "48af55fb-3be6-4c9d-8b19-80fd0eb13664");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ed95136c-1cbb-4c61-bd68-b633fe53df74",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "227dbfd6-4315-4189-a3a1-790aea41d332");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ExpenseDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ebfaf653-63e7-49bc-8aba-cb00fa5340ea",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d1aa4644-a610-45ca-86c2-261986c47ca6");

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
                name: "IX_ExpenseExpenseDetail_ExpensesId",
                table: "ExpenseExpenseDetail",
                column: "ExpensesId");
        }
    }
}
