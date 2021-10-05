using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vejledningsbooking.Persistence.Migrations
{
    public partial class rowversions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Rowversion",
                table: "Teachers",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Rowversion",
                table: "Students",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Rowversion",
                table: "Classes",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Rowversion",
                table: "Calenders",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Rowversion",
                table: "BookingWindows",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Rowversion",
                table: "Bookings",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rowversion",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Rowversion",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Rowversion",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Rowversion",
                table: "Calenders");

            migrationBuilder.DropColumn(
                name: "Rowversion",
                table: "BookingWindows");

            migrationBuilder.DropColumn(
                name: "Rowversion",
                table: "Bookings");
        }
    }
}
