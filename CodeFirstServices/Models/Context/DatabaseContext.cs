using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CodeFirstServices.Models.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base ("CodeFirstConnection")
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> cities { get; set; }

    }
}