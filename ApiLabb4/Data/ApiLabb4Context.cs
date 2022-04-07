using ApiLabb4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Data
{
    public class ApiLabb4Context : DbContext
    {
        public ApiLabb4Context(DbContextOptions<ApiLabb4Context> options) : base(options)
        {
             
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<WebSite> WebSites { get; set; }

    }
}
