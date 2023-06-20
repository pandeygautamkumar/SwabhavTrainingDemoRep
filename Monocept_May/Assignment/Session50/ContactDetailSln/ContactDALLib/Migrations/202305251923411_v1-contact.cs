namespace ContactDALLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1contact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Sn = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        MobileNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Sn);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
