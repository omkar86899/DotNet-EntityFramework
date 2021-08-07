namespace ConsoleEFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1_balanceAdd_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Balance");
        }
    }
}
