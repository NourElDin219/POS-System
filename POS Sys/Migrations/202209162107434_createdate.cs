namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Double(nullable: false),
                        Pay = c.Double(nullable: false),
                        Discount = c.Int(nullable: false),
                        PaymentMethod = c.String(),
                        UserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.InvoiceProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.InvoiceId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.InvoiceProducts", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "UserId", "dbo.Users");
            DropIndex("dbo.InvoiceProducts", new[] { "ProductId" });
            DropIndex("dbo.InvoiceProducts", new[] { "InvoiceId" });
            DropIndex("dbo.Invoices", new[] { "UserId" });
            DropTable("dbo.InvoiceProducts");
            DropTable("dbo.Invoices");
        }
    }
}
