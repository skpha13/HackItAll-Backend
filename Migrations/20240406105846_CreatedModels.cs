using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackItAllBackend.Migrations
{
    /// <inheritdoc />
    public partial class CreatedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battery_Model_modelId",
                table: "Battery");

            migrationBuilder.DropForeignKey(
                name: "FK_Battery_Station_stationId",
                table: "Battery");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_modelId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Station",
                table: "Station");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Battery",
                table: "Battery");

            migrationBuilder.RenameTable(
                name: "Station",
                newName: "Stations");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Models");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.RenameTable(
                name: "Battery",
                newName: "Batteries");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cars",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "modelId",
                table: "Cars",
                newName: "batteryModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_modelId",
                table: "Cars",
                newName: "IX_Cars_batteryModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Battery_stationId",
                table: "Batteries",
                newName: "IX_Batteries_stationId");

            migrationBuilder.RenameIndex(
                name: "IX_Battery_modelId",
                table: "Batteries",
                newName: "IX_Batteries_modelId");

            migrationBuilder.AlterColumn<int>(
                name: "chargingStations",
                table: "Stations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stations",
                table: "Stations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batteries",
                table: "Batteries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Models_modelId",
                table: "Batteries",
                column: "modelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Stations_stationId",
                table: "Batteries",
                column: "stationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_batteryModelId",
                table: "Cars",
                column: "batteryModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Models_modelId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Stations_stationId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_batteryModelId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stations",
                table: "Stations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batteries",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "brand",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Stations",
                newName: "Station");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Model");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");

            migrationBuilder.RenameTable(
                name: "Batteries",
                newName: "Battery");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "Car",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "batteryModelId",
                table: "Car",
                newName: "modelId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_batteryModelId",
                table: "Car",
                newName: "IX_Car_modelId");

            migrationBuilder.RenameIndex(
                name: "IX_Batteries_stationId",
                table: "Battery",
                newName: "IX_Battery_stationId");

            migrationBuilder.RenameIndex(
                name: "IX_Batteries_modelId",
                table: "Battery",
                newName: "IX_Battery_modelId");

            migrationBuilder.AlterColumn<string>(
                name: "chargingStations",
                table: "Station",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Station",
                table: "Station",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Battery",
                table: "Battery",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Battery_Model_modelId",
                table: "Battery",
                column: "modelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Battery_Station_stationId",
                table: "Battery",
                column: "stationId",
                principalTable: "Station",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_modelId",
                table: "Car",
                column: "modelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
