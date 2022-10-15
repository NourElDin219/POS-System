namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_profit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "TotalProfit", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "TotalProfit");
        }
    }
}
