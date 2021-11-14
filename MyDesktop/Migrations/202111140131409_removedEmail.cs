namespace MyDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedEmail : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
        }
    }
}
