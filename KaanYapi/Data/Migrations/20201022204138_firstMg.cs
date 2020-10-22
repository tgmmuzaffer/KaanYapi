using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KaanYapi.Migrations
{
    public partial class firstMg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    BlogHeader = table.Column<string>(nullable: false),
                    BlogBody = table.Column<string>(nullable: false),
                    BlogDate = table.Column<DateTime>(nullable: false),
                    ViewCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "defaultPictureModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LittlePicturePath = table.Column<string>(nullable: false),
                    BigPicturePath = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_defaultPictureModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    LongDescription = table.Column<string>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pageDescriptionModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pageDescriptionModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: false),
                    Barcode = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    LongDescription = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    IsNew = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "blogPictureModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: false),
                    PicturePath = table.Column<string>(nullable: false),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPictureModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogPictureModels_blogModels_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jobPictureModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: true),
                    PicturePath = table.Column<string>(nullable: true),
                    JobId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobPictureModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jobPictureModels_jobModels_JobId",
                        column: x => x.JobId,
                        principalTable: "jobModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "categoryModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: false),
                    PicturePath = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categoryModels_productModels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "productModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pictureModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: false),
                    PicturePath = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pictureModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pictureModels_productModels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "productModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productPropertyModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productPropertyModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productPropertyModels_productModels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "productModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reviewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false),
                    Star = table.Column<int>(nullable: false),
                    ContentOwner = table.Column<string>(nullable: false),
                    IsOk = table.Column<bool>(nullable: false),
                    EMail = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reviewModels_blogModels_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reviewModels_productModels_ProductId",
                        column: x => x.ProductId,
                        principalTable: "productModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subCategoryModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CategoriesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCategoryModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subCategoryModels_categoryModels_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "categoryModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogPictureModels_BlogId",
                table: "blogPictureModels",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_categoryModels_ProductId",
                table: "categoryModels",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_jobPictureModels_JobId",
                table: "jobPictureModels",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_pictureModels_ProductId",
                table: "pictureModels",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productPropertyModels_ProductId",
                table: "productPropertyModels",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_reviewModels_BlogId",
                table: "reviewModels",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_reviewModels_ProductId",
                table: "reviewModels",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_subCategoryModels_CategoriesId",
                table: "subCategoryModels",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogPictureModels");

            migrationBuilder.DropTable(
                name: "defaultPictureModels");

            migrationBuilder.DropTable(
                name: "jobPictureModels");

            migrationBuilder.DropTable(
                name: "pageDescriptionModels");

            migrationBuilder.DropTable(
                name: "pictureModels");

            migrationBuilder.DropTable(
                name: "productPropertyModels");

            migrationBuilder.DropTable(
                name: "reviewModels");

            migrationBuilder.DropTable(
                name: "subCategoryModels");

            migrationBuilder.DropTable(
                name: "jobModels");

            migrationBuilder.DropTable(
                name: "blogModels");

            migrationBuilder.DropTable(
                name: "categoryModels");

            migrationBuilder.DropTable(
                name: "productModels");
        }
    }
}
