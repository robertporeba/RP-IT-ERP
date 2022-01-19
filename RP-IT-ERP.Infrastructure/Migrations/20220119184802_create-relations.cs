using Microsoft.EntityFrameworkCore.Migrations;

namespace RP_IT_ERP.Infrastructure.Migrations
{
    public partial class createrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "TaskType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "TaskStatus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElementId",
                table: "Task",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaportId",
                table: "RaportType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskType_TaskId",
                table: "TaskType",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatus_TaskId",
                table: "TaskStatus",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_ElementId",
                table: "Task",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_RaportType_RaportId",
                table: "RaportType",
                column: "RaportId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_TaskId",
                table: "Client",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Task_TaskId",
                table: "Client",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RaportType_Raport_RaportId",
                table: "RaportType",
                column: "RaportId",
                principalTable: "Raport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Element_ElementId",
                table: "Task",
                column: "ElementId",
                principalTable: "Element",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskStatus_Task_TaskId",
                table: "TaskStatus",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskType_Task_TaskId",
                table: "TaskType",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Task_TaskId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_RaportType_Raport_RaportId",
                table: "RaportType");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Element_ElementId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskStatus_Task_TaskId",
                table: "TaskStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskType_Task_TaskId",
                table: "TaskType");

            migrationBuilder.DropIndex(
                name: "IX_TaskType_TaskId",
                table: "TaskType");

            migrationBuilder.DropIndex(
                name: "IX_TaskStatus_TaskId",
                table: "TaskStatus");

            migrationBuilder.DropIndex(
                name: "IX_Task_ElementId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_RaportType_RaportId",
                table: "RaportType");

            migrationBuilder.DropIndex(
                name: "IX_Client_TaskId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "TaskType");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "TaskStatus");

            migrationBuilder.DropColumn(
                name: "ElementId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "RaportId",
                table: "RaportType");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Client");
        }
    }
}
