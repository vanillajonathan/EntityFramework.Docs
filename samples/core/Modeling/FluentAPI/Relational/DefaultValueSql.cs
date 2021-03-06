﻿using Microsoft.EntityFrameworkCore;
using System;

namespace EFModeling.FluentAPI.Relational.DefaultValueSql
{
    class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(b => b.Created)
                .HasDefaultValueSql("getdate()");
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }
}
