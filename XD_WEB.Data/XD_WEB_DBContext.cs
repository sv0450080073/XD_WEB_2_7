﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XD_WEB.Model.Models;

namespace XD_WEB.Data
{
    public class XD_WEB_DBContext :DbContext
    {
        public XD_WEB_DBContext() : base("XD_WEBConnection") 
            {
            this.Configuration.LazyLoadingEnabled = false;

            }
        //khai báo tất cả các bảng ra 
        public DbSet<Credential> Credentials { set; get; }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages{ set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> systemConfigs { set; get; }
        public DbSet<Tag> Tags{ set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<UserGroup> userGroups { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        protected  override void OnModelCreating(DbModelBuilder builder)
        {

        }

    }
}