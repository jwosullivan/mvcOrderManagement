using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO


namespace mvcOrderManagement
{

    public class OrderContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public string dbFile { get; } = @"mvcOrderManagment.db";
        public string dbFullPath { get;  } 

        public OrderContext()
        {
            dbFullPath = System.IO.Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"data" , dbFile);


            if (File.Exists(dbFullPath)){
                // if dat
                throw new FileNotFoundException(string.Format("Database file is missing: {0}", dbFullPath));
            }


        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={dbFullPath}");
    }

    [Table("Orders")]
    public class Order
    {
        public int OrderId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new();
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}