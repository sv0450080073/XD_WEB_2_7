namespace XD_WEB.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
   
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using XD_WEB.Data;
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
    }
}