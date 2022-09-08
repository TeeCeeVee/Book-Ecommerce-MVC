﻿using EcommerceBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBookWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
