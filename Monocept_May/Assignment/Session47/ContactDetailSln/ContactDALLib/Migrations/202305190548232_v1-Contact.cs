namespace ContactDALLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1Contact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity:false),
                        Name = c.String(),
                        MobileNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
