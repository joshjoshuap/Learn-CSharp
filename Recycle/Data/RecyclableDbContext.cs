using Recycle.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Recycle.Data
{
    public class RecyclableDbContext : DbContext
    { 
        public DbSet<RecyclableType> RecyclableType { get; set; }
        public DbSet<RecyclableItem> RecyclableItem { get; set; }

    }
}