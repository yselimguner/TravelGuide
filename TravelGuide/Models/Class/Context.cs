using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TravelGuide.Models.Class
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comments> Comments { get; set; } //Tek aynı ada sahip olan bu.
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skills> Skills { get; set; }

    }
}