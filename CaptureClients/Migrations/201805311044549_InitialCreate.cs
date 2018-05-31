namespace CaptureClients.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        ContactNumber = c.String(nullable: false, maxLength: 15),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MyProperty = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Latitude = c.String(),
                        longitude = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Contacts", new[] { "CustomerId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Contacts");
        }
    }
}
