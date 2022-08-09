using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookDB.Migrations
{
    public partial class SecondSchemaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Publishers_PublisherId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "BookBookType");

            migrationBuilder.DropTable(
                name: "BookDomain");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "BookTypes");

            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropIndex(
                name: "IX_Locations_PublisherId",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "AuthorLastName",
                table: "Authors",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "AuthorFirstName",
                table: "Authors",
                newName: "AuthorName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Authors",
                newName: "AuthorLastName");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Authors",
                newName: "AuthorFirstName");

            migrationBuilder.CreateTable(
                name: "BookTypes",
                columns: table => new
                {
                    BookTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTypes", x => x.BookTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    DomainId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.DomainId);
                });

            migrationBuilder.CreateTable(
                name: "BookBookType",
                columns: table => new
                {
                    BookTypesBookTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    BooksBookId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBookType", x => new { x.BookTypesBookTypeId, x.BooksBookId });
                    table.ForeignKey(
                        name: "FK_BookBookType_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBookType_BookTypes_BookTypesBookTypeId",
                        column: x => x.BookTypesBookTypeId,
                        principalTable: "BookTypes",
                        principalColumn: "BookTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDomain",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "INTEGER", nullable: false),
                    DomainsDomainId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDomain", x => new { x.BooksBookId, x.DomainsDomainId });
                    table.ForeignKey(
                        name: "FK_BookDomain_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookDomain_Domains_DomainsDomainId",
                        column: x => x.DomainsDomainId,
                        principalTable: "Domains",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_PublisherId",
                table: "Locations",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBookType_BooksBookId",
                table: "BookBookType",
                column: "BooksBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDomain_DomainsDomainId",
                table: "BookDomain",
                column: "DomainsDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AuthorId",
                table: "Contacts",
                column: "AuthorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Publishers_PublisherId",
                table: "Locations",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
