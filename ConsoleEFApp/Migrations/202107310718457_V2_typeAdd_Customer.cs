namespace ConsoleEFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2_typeAdd_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Type");
        }
    }
}
