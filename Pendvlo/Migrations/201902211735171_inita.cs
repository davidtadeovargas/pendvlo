namespace Pendvlo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inita : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Created");
        }
    }
}
