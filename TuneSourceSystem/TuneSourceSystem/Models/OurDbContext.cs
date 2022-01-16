using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TuneSourceSystem.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<useraccount> userAccount { get; set; }
    }
}