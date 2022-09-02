namespace POS_Sys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ShopQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "InvQuantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UserName", c => c.String(maxLength: 450));
            CreateIndex("dbo.Users", "UserName", unique: true);
            DropColumn("dbo.Products", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            DropIndex("dbo.Users", new[] { "UserName" });
            AlterColumn("dbo.Users", "UserName", c => c.String());
            DropColumn("dbo.Products", "InvQuantity");
            DropColumn("dbo.Products", "ShopQuantity");
        }
    }
}
