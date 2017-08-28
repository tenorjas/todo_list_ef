using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace todo_list.Migrations
{
    public partial class Changed_Complete_to_IsComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Complete",
                table: "TodoModel");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "TodoModel",
                type: "bool",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "TodoModel");

            migrationBuilder.AddColumn<bool>(
                name: "Complete",
                table: "TodoModel",
                nullable: false,
                defaultValue: false);
        }
    }
}
