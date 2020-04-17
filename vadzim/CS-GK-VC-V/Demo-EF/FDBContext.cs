using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_EF
{
    public class FDBContext : DbContext
    {
        public DbSet<FahrzeugEF> Fahrzeuge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=FahrzeugeDb.db");
    }
}
