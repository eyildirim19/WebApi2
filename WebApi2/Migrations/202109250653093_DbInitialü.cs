namespace WebApi2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInitialü : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanicis");
        }
    }
}
