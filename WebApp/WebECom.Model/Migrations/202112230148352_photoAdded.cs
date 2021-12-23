namespace WebECom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photoAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "PhotoPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "PhotoPath");
        }
    }
}
