namespace Task_13_Feb_Entity_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cust_id = c.Int(nullable: false, identity: true),
                        Cust_name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Cust_id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Product_id = c.Int(nullable: false, identity: true),
                        Product_name = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Product_id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Cust_id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.Cust_id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: true)
                .Index(t => t.Cust_id)
                .Index(t => t.Product_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Purchases", "Cust_id", "dbo.Customers");
            DropIndex("dbo.Purchases", new[] { "Product_id" });
            DropIndex("dbo.Purchases", new[] { "Cust_id" });
            DropTable("dbo.Purchases");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
        }
    }
}
