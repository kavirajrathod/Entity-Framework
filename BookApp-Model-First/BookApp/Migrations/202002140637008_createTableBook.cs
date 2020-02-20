namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Aid = c.Int(nullable: false, identity: true),
                        Author_name = c.String(),
                        Author_Address = c.String(),
                    })
                .PrimaryKey(t => t.Aid);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Bid = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Bid);
            
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        P_num = c.Int(nullable: false, identity: true),
                        Bid = c.Int(nullable: false),
                        Aid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.P_num)
                .ForeignKey("dbo.Authors", t => t.Aid, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Bid, cascadeDelete: true)
                .Index(t => t.Bid)
                .Index(t => t.Aid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "Bid", "dbo.Books");
            DropForeignKey("dbo.Details", "Aid", "dbo.Authors");
            DropIndex("dbo.Details", new[] { "Aid" });
            DropIndex("dbo.Details", new[] { "Bid" });
            DropTable("dbo.Details");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
