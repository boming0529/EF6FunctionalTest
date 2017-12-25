namespace EF7TEST.Areas.I18n.Migrations.I18n
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysUser",
                c => new
                    {
                        SysUserId = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        LanguageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SysUserId)
                .ForeignKey("dbo.Language", t => t.LanguageId, cascadeDelete: true)
                .Index(t => t.LanguageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SysUser", "LanguageId", "dbo.Language");
            DropIndex("dbo.SysUser", new[] { "LanguageId" });
            DropTable("dbo.SysUser");
            DropTable("dbo.Language");
        }
    }
}
