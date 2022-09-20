namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeQt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.InvoiceProducts", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InvoiceProducts", "Quantity", c => c.Int(nullable: false));
        }
    }
}
