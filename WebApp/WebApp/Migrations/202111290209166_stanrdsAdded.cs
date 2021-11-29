namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stanrdsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "StandardId", c => c.Int());
            CreateIndex("dbo.Students", "StandardId");
            AddForeignKey("dbo.Students", "StandardId", "dbo.Standards", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "StandardId" });
            DropColumn("dbo.Students", "StandardId");
            DropTable("dbo.Standards");
        }
    }
}
