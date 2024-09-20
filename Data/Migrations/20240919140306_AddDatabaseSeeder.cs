using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CertificateMangerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabaseSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CertificateTypes",
                columns: new[] { "CertificateTypeID", "CertificateTypeName", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Permission of Printing", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1720), null, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1721) },
                    { 2, "OHSAS 18001", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1723), null, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1724) }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "CreatedAt", "DeletedAt", "DepartmentName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1346), null, "HR", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1362) },
                    { 2, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1364), null, "IT", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1365) }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "City", "CreatedAt", "DeletedAt", "Name", "SupplierIndex", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "City A", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1616), null, "Supplier One", 1001, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1617) },
                    { 2, "City B", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1620), null, "Supplier Two", 1002, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1620) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1666), null, "jackmangosa@example.com", "Jack", "Mangosa", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1668), "jackmangosa" },
                    { 2, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1670), null, "danmangosa@example.com", "Dan", "Mangosa", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1671), "danmangosa" },
                    { 3, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1673), null, "cedmangosa@example.com", "Ced", "Mangosa", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1674), "cedmangosa" }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "ParticipantID", "CreatedAt", "DeletedAt", "DepartmentID", "FirstName", "LastName", "Plant", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1561), null, 1, "John", "Doe", "Plant A", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1563) },
                    { 2, new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1568), null, 2, "Jane", "Smith", "Plant B", new DateTime(2024, 9, 19, 16, 3, 5, 649, DateTimeKind.Local).AddTicks(1568) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CertificateTypes",
                keyColumn: "CertificateTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CertificateTypes",
                keyColumn: "CertificateTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2);
        }
    }
}
