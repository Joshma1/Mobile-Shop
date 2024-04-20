using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Project.Net.Models;
using Type = Project.Net.Models;

namespace Project.Net.Data
{
    
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
  {
    
        
         public DbSet<Product> Products { get; set; }
         public DbSet<MyType> Types  { get; set; }
         public DbSet<Brand> Brands { get; set; }
        public DbSet<MenuItem> Menus { get; set; }
        //login table


       // public object AppDbContextModelSnapshot { get; internal set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                   
            var product1 = new Product() { Id = 1,Name = "Samsung 100",  Category = "Phones",
            Price = 900, Description = "New Smartphone" };
            var product2 = new Product() { Id = 2, Name = "Samsung Galaxy",  Category = "Phones",
            Price = 800, Description = "New Smartphone 2024" };
            var product3 = new Product() { Id = 3, Name = "iphone 15",  Category = "Phones",
            Price = 1000, Description = "New Smartphone 2024" };
            var product4 = new Product() { Id = 4, Name = "Nokia E5",  Category = "Phones",
            Price = 600, Description = "New Smartphone 2024", ImageUrl = "" };
            

            
            var type1 = new MyType() { Id = 1, Name = "Electronics", Category = "Consumer Electronics" };
            var type2 = new MyType() { Id = 2, Name = "Clothing", Category = "Apparel" };
            var type3 = new MyType() { Id = 3, Name = "Furniture", Category = "Home Furnishings" };
            
            var brand1 = new Brand { Id = 1, Name = "Brand A", Category = "Category A" };
            var brand2 = new Brand { Id = 2, Name = "Brand B", Category = "Category B" };
            var brand3 = new Brand { Id = 3, Name = "Brand C", Category = "Category C" };

            var menu1 = new MenuItem { Id = 1, Name = "Products",Category = "Mobil Phones", Url = "/Products", ParentId = 0 };
            var menu2 = new MenuItem { Id =2, Name = "Types",Category = "Mobil Types ", Url = "/Types", ParentId = 0 };
            var menu3 = new MenuItem { Id =3, Name = "Brands", Category = "Mobil Brands ",Url = "/Brands", ParentId = 0 };
            // Add more menu items as needed new MenuItem { Name = "Home", Url = "/", ParentId = 0 },

            //login 
      


               modelBuilder.Entity<Product>().HasData(product1, product2, product3, product4);
        }

        // internal Product Product(object id)
        // {
        //     throw new NotImplementedException();
        // }
}
}