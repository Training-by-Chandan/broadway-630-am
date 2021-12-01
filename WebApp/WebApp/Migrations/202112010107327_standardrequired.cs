namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class standardrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Standards", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Standards", "Name", c => c.String());
        }
    }
}
