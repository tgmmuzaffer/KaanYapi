using KaanYapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        DbSet<BlogPictureModel> blogPictureModels{get; set;}
        DbSet<BlogModel> blogModels{get; set;}
        DbSet<CategoryModel> categoryModels{get; set;}
        DbSet<DefaultPictureModel> defaultPictureModels{get; set;}
        DbSet<JobModel> jobModels{get; set;}
        DbSet<JobPictureModel> jobPictureModels{get; set;}
        DbSet<PageDescriptionModel> pageDescriptionModels{get; set;}
        DbSet<PictureModel> pictureModels{get; set;}
        DbSet<ProductModel> productModels{get; set;}
        DbSet<ProductPropertyModel> productPropertyModels{get; set;}
        DbSet<ReviewModel> reviewModels{get; set;}
        DbSet<SubCategoryModel> subCategoryModels{get; set;}
        DbSet<AdminMapAddress> adminMapAddressesModels { get; set; }
    }
}
