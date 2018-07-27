namespace XD_WEB.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using XD_WEB.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<XD_WEB.Data.XD_WEB_DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(XD_WEB.Data.XD_WEB_DBContext context)
        {
            CreateProductCategoySample(context);
            CreateSlide(context);
            CreatePage(context);
            CreateContactDetail(context);
            //  This method will be called after migrating to the latest version.

            /*var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new XD_WEB_DBContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new XD_WEB_DBContext()));

            var user = new ApplicationUser()
            {
                UserName = "tedu",
                Email = "tedu.international@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Technology Education"
            };

            manager.Create(user, "123654$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tedu.international@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });*/
        }

        //hàm thêm phoductcategory vào database

        private void CreateProductCategoySample(XD_WEB.Data.XD_WEB_DBContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                   new ProductCategory(){Name="Điện lạnh",Alias="dien-lanh",Status=true},
                   new ProductCategory(){Name="Viễn thông",Alias="vien-thong",Status=true},
                   new ProductCategory(){Name="Đồ gia dụng",Alias="do-gia-dung",Status=true},
                   new ProductCategory(){Name="Mỹ phẩm",Alias="my-pham",Status=true}
                };

                context.ProductCategories.AddRange(listProductCategory);

                context.SaveChanges();
            }
        }
        private void CreateSlide(XD_WEB_DBContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide() { Name="Slide 1",DisplayOrder=1,Status=true,URL="#",Image="/Assets/client/images/bag.jpg",
                               Content=@"<h2>FLAT 50% 0FF</h2>
								<label>FOR ALL PURCHASE <b>VALUE</b></label>
								<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>					
								<span class=""on-get"">GET NOW</span>" },
                      new Slide()
                      { Name="Slide 2",DisplayOrder=2,Status=true,URL="#",Image="/Assets/client/images/bag1.jpg",
                      Content=@"<h2>FLAT 50% 0FF</h2>
								<label>FOR ALL PURCHASE <b>VALUE</b></label>
								<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>					
								<span class=""on-get"">GET NOW</span>"}

                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }
        private void CreatePage(XD_WEB_DBContext context)
        {
            if (context.Pages.Count() == 0)
            {
                var page = new Page()
                {
                    Name="Giới thiệu",
                    Alias = "gioi-thieu",
                    Content = "Đây là trang web xử lý tốc độ cao ",
                    Status = true
                };
            context.Pages.Add(page);
            context.SaveChanges();

            }
        }


        private void CreateContactDetail(XD_WEB_DBContext context)
        {
            if (context.ContactDetails.Count() == 0)
            {
                var page = new XD_WEB.Model.Models.ContactDetail()
                {
                    Name = "Shop thời trang",
                    Address="236B Lê Văn Sỹ",
                    Email="nkmanh1997@gmail.com",
                    Lat= 10.7968635,
                    Lng= 106.6665485,
                    Phone="01658801935", 
                   Other="",

                   
                    Status = true
                };
                context.ContactDetails.Add(page);
                context.SaveChanges();

            }
        }
    }
}
