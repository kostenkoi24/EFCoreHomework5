//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EFCoreHomework5_1.Entity
//{
//    class DatabaseContext : DbContext
//    {
//        public DbSet<Cart> Carts { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<KeyParams> KeyParams { get; set; }
//        public DbSet<Product> Products { get; set; }
//        public DbSet<User> Users { get; set; }
//        public DbSet<Word> Words { get; set; }


//        public DatabaseContext()
//        {
//            Database.EnsureCreated();
//        }


//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("Server=localhost;Database=EFCoreHomework3;Trusted_Connection=True;");
//        }

//        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
//        {
//            protected override void Seed(DatabaseContext db)
//            {
//                //db.Phones.Add(new Phone { Name = "Nokia Lumia 630", Company = "Nokia", Price = 220 });
//                //db.Phones.Add(new Phone { Name = "iPhone 6", Company = "Apple", Price = 320 });
//                //db.Phones.Add(new Phone { Name = "LG G4", Company = "lG", Price = 260 });
//                //db.Phones.Add(new Phone { Name = "Samsung Galaxy S 6", Company = "Samsung", Price = 300 });
//                db.SaveChanges();
//            }
//        }

//        Scaffold-DbContext "Server=localhost;Database=EFCoreHomework3;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

//    }
//}
