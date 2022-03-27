﻿using EMERALD.CHEF.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace EMERALD.CHEF.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Item> Items {get; set;}
    }
}

