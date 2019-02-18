namespace Pendvlo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RFC = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        City = c.String(),
                        State = c.String(),
                        SalesMan_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.SalesMan_ID)
                .Index(t => t.SalesMan_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        User_ = c.String(),
                        Password = c.String(),
                        Sales = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Module_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Modules", t => t.Module_ID)
                .Index(t => t.Module_ID);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "SalesMan_ID", "dbo.Users");
            DropForeignKey("dbo.Users", "Module_ID", "dbo.Modules");
            DropIndex("dbo.Users", new[] { "Module_ID" });
            DropIndex("dbo.Customers", new[] { "SalesMan_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.Modules");
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
        }
    }
}
