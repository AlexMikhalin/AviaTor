using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace AviaTor.Models
{
    public class KlienContext:DbContext
    {
        public DbSet<Klients> Clienti { get; set; }
    }
}