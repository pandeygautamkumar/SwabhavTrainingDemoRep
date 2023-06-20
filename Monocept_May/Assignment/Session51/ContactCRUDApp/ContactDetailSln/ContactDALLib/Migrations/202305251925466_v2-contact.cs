namespace ContactDALLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2contact : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contacts");
            AddPrimaryKey("dbo.Contacts", "Id");
            DropColumn("dbo.Contacts", "Sn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Sn", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Contacts");
            AddPrimaryKey("dbo.Contacts", "Sn");
        }
    }
}
