﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Products_Web.Data.Entities;

namespace Products_Web.Data
{
    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        { }
    }
}
