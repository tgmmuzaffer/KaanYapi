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

        public virtual DbSet<BlogPictureModel> BlogPictures{get; set;}
        public virtual DbSet<BlogModel> Blogs{get; set;}
        public virtual DbSet<CategoryModel> Categories{get; set;}
        public virtual DbSet<DefaultPictureModel> DefaultPictures{get; set;}
        public virtual DbSet<JobModel> Jobs{get; set;}
        public virtual DbSet<JobPictureModel> JobPictures{get; set;}
        public virtual DbSet<PageDescriptionModel> PageDescriptions{get; set;}
        public virtual DbSet<PictureModel> Pictures{get; set;}
        public virtual DbSet<ProductModel> Products{get; set;}
        public virtual DbSet<ProductPropertyModel> ProductProperties{get; set;}
        public virtual DbSet<ReviewModel> Reviews{get; set;}
        public virtual DbSet<SubCategoryModel> SubCategories{get; set;}
        public virtual DbSet<ServiceModel> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>(x =>
            {
                x.Property(f => f.Price).HasColumnType("decimal(19,4)");

            });
        }

    }
}
