using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMadbestilling.Models;

namespace MvcMadbestilling.Data
{
    public class MvcMadbestillingContext : DbContext
    {
        public MvcMadbestillingContext(DbContextOptions<MvcMadbestillingContext> options) : base(options)
        {
        }

        public DbSet<Madbestillings> Madbestillings { get; set; }
    }
}
