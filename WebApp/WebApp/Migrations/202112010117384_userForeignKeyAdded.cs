namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userForeignKeyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Students", "UserId");
            AddForeignKey("dbo.Students", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "UserId" });
            DropColumn("dbo.Students", "UserId");
        }
    }
}
