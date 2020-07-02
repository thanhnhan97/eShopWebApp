using eShopeSolution.Data.Entities;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopeSolution.Data.Extensions
{
    public static class ModelBuilderExtensions 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            ///Dùng để tạo data ảo, k cần lưu lên database

            //Data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTittle", Value = "This is value" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword of eShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is Description" }
            );

            //Language
            modelBuilder.Entity<Language>().HasData(
                new Language()
                {
                    Id = "vi-VN",
                    Name = "Tiếng Việt",
                    IsDefault = true,
                },
                new Language()
                {
                    Id = "en-US",
                    Name = "English",
                    IsDefault = false
                }
            );

            //Category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 1,
                    Status = Enum.Status.Active
                },
                new Category()
                {
                    ID = 2,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 2,
                    Status = Enum.Status.Active
                }
            );


            //Category Translation
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm thời trang nam",
                    SeoTitle = "Sản phẩm thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-tshirt",
                    SeoDescription = "Men T-Shirt",
                    SeoTitle = "Men T-Shirt"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm thời trang nữ",
                    SeoTitle = "Sản phẩm thời trang nữ",
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-tshirt",
                    SeoDescription = "Women T-Shirt",
                    SeoTitle = "Women T-Shirt"
                }
            );

            //Product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ID = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0
                }
            );

            //Product Translation
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi trắng",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-trang",
                    SeoDescription = "Áo sơ mi trắng",
                    SeoTitle = "Áo sơ mi trắng",
                    Details = "Áo sơ mi trắng",
                    Description = "Áo sơ mi trắng"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-white-tshirt",
                    SeoDescription = "Men White T-Shirt",
                    SeoTitle = "Men White T-Shirt",
                    Details = "Men White T-Shirt",
                    Description = "Men White T-Shirt"
                }

            );

            //ProductInCategory
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    ProductID = 1,
                    CategoryID = 1
                }

            );
        }
    }
}
