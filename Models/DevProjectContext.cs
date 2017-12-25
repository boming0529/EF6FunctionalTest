using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EF7TEST.Models
{
    public class DevProjectContext : DbContext
    {
        public DevProjectContext()
            :base("DefaultConnection")
        {
            
        }

        public DbSet<Dev> Dev { set; get; }
        public DbSet<Project> Project { get; set; }
    }
}