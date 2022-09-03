namespace Recycle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RecyclableItems", "Id", "dbo.RecyclableTypes");
            DropIndex("dbo.RecyclableItems", new[] { "Id" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.RecyclableItems", "Id");
            AddForeignKey("dbo.RecyclableItems", "Id", "dbo.RecyclableTypes", "Id");
        }
    }
}
