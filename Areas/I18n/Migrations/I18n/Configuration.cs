namespace EF7TEST.Areas.I18n.Migrations.I18n
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EF7TEST.Areas.I18n.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EF7TEST.Areas.I18n.Models.I18nDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Areas\I18n\Migrations\I18n";
        }

        protected override void Seed(EF7TEST.Areas.I18n.Models.I18nDbContext context)
        {
            // add languages
            SeedHelper.SeedEnumData<Language, LanguageEnum>(context.Languages);
            context.SaveChanges();

            // add users
            context.SysUsers.Add(new SysUser
            {
                SysUserId = "boming",
                Name = "Lin Poming",
                LanguageId = LanguageEnum.Japanese
            });
            context.SaveChanges();
        }
    }
}
