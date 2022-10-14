namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editAP : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdvancePayments", "UserId", "dbo.Users");
            DropIndex("dbo.AdvancePayments", new[] { "UserId" });
            AddColumn("dbo.AdvancePayments", "UserName", c => c.String());
            AddColumn("dbo.AdvancePayments", "Description", c => c.String());
            AddColumn("dbo.AdvancePayments", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AdvancePayments", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "PurchasingPrice", c => c.Double(nullable: false));
            DropColumn("dbo.AdvancePayments", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdvancePayments", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "PurchasingPrice");
            DropColumn("dbo.AdvancePayments", "UpdatedDate");
            DropColumn("dbo.AdvancePayments", "CreatedDate");
            DropColumn("dbo.AdvancePayments", "Description");
            DropColumn("dbo.AdvancePayments", "UserName");
            CreateIndex("dbo.AdvancePayments", "UserId");
            AddForeignKey("dbo.AdvancePayments", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
