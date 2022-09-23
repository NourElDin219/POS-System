namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InvoiceProducts", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Discount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discount", c => c.Int(nullable: false));
            DropColumn("dbo.InvoiceProducts", "Quantity");
        }
    }
}
