using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace work_01.Migrations
{
    public partial class seedCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "CandidateId", "BirthDate", "CandidateName", "Email", "Fresher", "Password", "Picture" },
                values: new object[] { 1, new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "emran", "em@gmail.com", true, "abc123", "abc.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "CandidateId",
                keyValue: 1);
        }
    }
}
