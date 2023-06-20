namespace ContactDALLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7_contact : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contacts");
            AlterColumn("dbo.Contacts", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Contacts", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Contacts");
            AlterColumn("dbo.Contacts", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Contacts", "Id");
        }
    }
}
