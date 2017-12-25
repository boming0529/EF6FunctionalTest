using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EF7TEST.Areas.I18n.Models
{
    public class I18nDbContext : DbContext
    {
        public I18nDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<Language> Languages { get; set; }

        // Mothod
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}