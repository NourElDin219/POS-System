namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removePPrice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "PurchasingPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "PurchasingPrice", c => c.Double(nullable: false));
        }
    }
}
