namespace assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Description = c.String(),
                        DestinyID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Destinies", t => t.DestinyID)
                .Index(t => t.DestinyID);
            
            CreateTable(
                "dbo.Destinies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "DestinyID", "dbo.Destinies");
            DropIndex("dbo.Characters", new[] { "DestinyID" });
            DropTable("dbo.Destinies");
            DropTable("dbo.Characters");
        }
    }
}
