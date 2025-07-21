using System.Collections.Generic;
using System.Data.Entity;

namespace GadgetsOnline.Models
{
    public class GadgetsOnlineInitializer : CreateDatabaseIfNotExists<GadgetsOnlineEntities>
    {
        protected override void Seed(GadgetsOnlineEntities context)
        {
            // Categories
            var categories = new List<Category>
        {
            new Category { CategoryId = 1, Name = "Mobile Phones", Description = "Latest collection of Mobile Phones" },
            new Category { CategoryId = 2, Name = "Laptops", Description = "Latest Laptops in 2022" },
            new Category { CategoryId = 3, Name = "Desktops", Description = "Latest Desktops in 2022" },
            new Category { CategoryId = 4, Name = "Audio", Description = "Latest audio devices" },
            new Category { CategoryId = 5, Name = "Accessories", Description = "USB Cables, Mobile chargers and Keyboards etc" }
        };
            categories.ForEach(c => context.Categories.Add(c));

            // Products
            var products = new List<Product>
        {
            new Product { ProductId = 1, CategoryId = 1, Name = "Phone 12", Price = 699.00M, ProductArtUrl = "/Content/Images/Mobile/1.jpg" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Phone 13 Pro", Price = 999.00M, ProductArtUrl = "/Content/Images/Mobile/2.jpg" },
            // Add all other products here
        };
            products.ForEach(p => context.Products.Add(p));

            context.SaveChanges();
        }
    }
}
