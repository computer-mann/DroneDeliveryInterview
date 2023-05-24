using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DroneDelivery.Migrations.Drone
{
    /// <inheritdoc />
    public partial class FixedRwoVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Medications",
                newName: "RowVersion");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Drones",
                newName: "RowVersion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RowVersion",
                table: "Medications",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "RowVersion",
                table: "Drones",
                newName: "Timestamp");
        }
    }
}
