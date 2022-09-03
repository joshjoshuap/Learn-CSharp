namespace Recycle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecyclableItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RecyclableId = c.Int(nullable: false),
                        Description = c.String(maxLength: 150),
                        Weight = c.Int(nullable: false),
                        ComputedRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RecyclableTypes", t => t.RecyclableId, cascadeDelete: true)
                .Index(t => t.RecyclableId);
            
            CreateTable(
                "dbo.RecyclableTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 100),
                        Rate = c.Int(nullable: false),
                        MinKg = c.Int(nullable: false),
                        MaxKg = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecyclableItems", "RecyclableId", "dbo.RecyclableTypes");
            DropIndex("dbo.RecyclableItems", new[] { "RecyclableId" });
            DropTable("dbo.RecyclableTypes");
            DropTable("dbo.RecyclableItems");
        }
    }
}
