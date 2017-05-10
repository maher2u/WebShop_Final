namespace WebShop.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebShop.Models.DatabaseModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebShop.Models.DatabaseModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var products = new List<Product>
            {
                new Product { Type="watches",Category =" Smart Watch"  , Name= "ZED Watch Header ", Description= "xxxxxxxxxxxxxxxxx" ,Price=4490,Image= "/Content/Images/Watches/ZED-watch-header.png"},
                new Product { Type="watches",Category=" Smart Watch"   , Name = "Speed up Smart Watch ", Description= "xxxxxxxxxxxxxxxxx " ,Price=3890, Image="/Content/Images/Watches/speedup-smartwatch-red.png" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "JACQUES LEMANS LONDON MEN'S WATCH ", Description = "xxxxxxxxxxxxxxxxx" ,Price=789,Image="/Content/Images/Watches/1-1844D_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "CITIZEN MEN'S WATCH ", Description = "xxxxxxxxxxxxxxxxx " ,Price=998, Image="/Content/Images/Watches/AN353052L_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "CITIZEN SUPER SKY HAWK ", Description =" xxxxxxxxxxxxxxxxx" ,Price=2998, Image="/Content/Images/Watches/jy002064e_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "Harry Winston ", Description = "xxxxxxxxxxxxxxxxx " ,Price=3560, Image="/Content/Images/Watches/0101.jpg" },

                new Product { Type="watches",Category =" Smart Watch"  , Name= " Watch Header ", Description= "xxxxxxxxxxxxxxxxx" ,Price=4490,Image= "/Content/Images/Watches/ZED-watch-header.png"},
                new Product { Type="watches",Category=" Smart Watch"   , Name = "Speed up  ", Description= "xxxxxxxxxxxxxxxxx " ,Price=3890, Image="/Content/Images/Watches/speedup-smartwatch-red.png" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "JACQUES LEMANS  ", Description = "xxxxxxxxxxxxxxxxx" ,Price=789,Image="/Content/Images/Watches/1-1844D_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "CITIZEN MEN'S  ", Description = "xxxxxxxxxxxxxxxxx " ,Price=998, Image="/Content/Images/Watches/AN353052L_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "SKY HAWK ", Description =" xxxxxxxxxxxxxxxxx" ,Price=2998, Image="/Content/Images/Watches/jy002064e_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "Harry  ", Description = "xxxxxxxxxxxxxxxxx " ,Price=3560, Image="/Content/Images/Watches/0101.jpg" },

                new Product { Type="watches",Category =" Smart Watch"  , Name= "ZED  ", Description= "xxxxxxxxxxxxxxxxx" ,Price=4490,Image= "/Content/Images/Watches/ZED-watch-header.png"},
                new Product { Type="watches",Category=" Smart Watch"   , Name = " up Smart Watch ", Description= "xxxxxxxxxxxxxxxxx " ,Price=3890, Image="/Content/Images/Watches/speedup-smartwatch-red.png" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = " LONDON MEN'S WATCH ", Description = "xxxxxxxxxxxxxxxxx" ,Price=789,Image="/Content/Images/Watches/1-1844D_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = " MEN'S WATCH ", Description = "xxxxxxxxxxxxxxxxx " ,Price=998, Image="/Content/Images/Watches/AN353052L_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = "CITIZEN SUPER  ", Description =" xxxxxxxxxxxxxxxxx" ,Price=2998, Image="/Content/Images/Watches/jy002064e_1.jpg" },
                new Product { Type="watches",Category=" Elegant Watch" , Name = " Winston ", Description = "xxxxxxxxxxxxxxxxx " ,Price=3560, Image="/Content/Images/Watches/0101.jpg" },

                new Product { Type="jewellery",Category=" Bracelet"    , Name = "Love Knot Link Bracelet ", Description = "xxxxxxxxxxxxxxxxx " ,Price= 2908, Image="/Content/Images/Jewellery/_11753307.png" },
                new Product { Type="jewellery",Category=" Necklace"    , Name = "Love Knot Pendant Necklace ", Description = "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_11753803.png" },
                new Product { Type="jewellery",Category=" Ring"        , Name = "Love Knot Ring ", Description= "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_12975215.png" },

               new Product { Type="jewellery",Category=" Bracelet"    , Name = "Love Knot ", Description = "xxxxxxxxxxxxxxxxx " ,Price= 2908, Image="/Content/Images/Jewellery/_11753307.png" },
                new Product { Type="jewellery",Category=" Necklace"    , Name = " Pendant Necklace ", Description = "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_11753803.png" },
                new Product { Type="jewellery",Category=" Ring"        , Name = " Knot Ring ", Description= "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_12975215.png" },

                new Product { Type="jewellery",Category=" Bracelet"    , Name = " Link Bracelet ", Description = "xxxxxxxxxxxxxxxxx " ,Price= 2908, Image="/Content/Images/Jewellery/_11753307.png" },
                new Product { Type="jewellery",Category=" Necklace"    , Name = " Knot Pendant Necklace ", Description = "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_11753803.png" },
                new Product { Type="jewellery",Category=" Ring"        , Name = "Loveley Knot Ring ", Description= "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_12975215.png" },

                new Product { Type="jewellery",Category=" Bracelet"    , Name = " Bracelet ", Description = "xxxxxxxxxxxxxxxxx " ,Price= 2908, Image="/Content/Images/Jewellery/_11753307.png" },
                new Product { Type="jewellery",Category=" Necklace"    , Name = "Love Knot Pendant  ", Description = "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_11753803.png" },
                new Product { Type="jewellery",Category=" Ring"        , Name = " Ring ", Description= "xxxxxxxxxxxxxxxxx " ,Price=2423, Image="/Content/Images/Jewellery/_12975215.png" }
            };


            context.SaveChanges();
            products.ForEach(s => context.Products.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();



        }
    }
}
