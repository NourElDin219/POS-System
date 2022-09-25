namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "Discount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoices", "Discount", c => c.Int(nullable: false));
        }
    }
}
