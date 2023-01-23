using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMedia.Migrations
{
    public partial class profilepicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Profiles",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Profiles");
        }
    }
}
