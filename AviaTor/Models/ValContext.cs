using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace AviaTor.Models
{
    public class ValContext:DbContext
    {
        public DbSet<Value> Values { get; set; }
    }
}