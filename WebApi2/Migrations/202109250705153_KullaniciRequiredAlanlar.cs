namespace WebApi2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KullaniciRequiredAlanlar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kullanicis", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Kullanicis", "Sifre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kullanicis", "Sifre", c => c.String());
            AlterColumn("dbo.Kullanicis", "Email", c => c.String());
        }
    }
}
