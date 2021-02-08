using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiPageWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactsId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactsId", "Address", "Name", "Note", "Number" },
                values: new object[,]
                {
                    { 1, "1122 Over Here Dr", "Hayley", "Wifey", "515-555-1234" },
                    { 2, "123 Over There Ct", "Griff", "Son", "515-555-4321" },
                    { 3, "987 Where St", "Beck", "Son", "515-555-1324" },
                    { 4, "7890 Doghouse Ln", "Wally", "Woof", "515-555-9876" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
