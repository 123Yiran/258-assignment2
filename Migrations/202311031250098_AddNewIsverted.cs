namespace assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewIsverted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Destinies", "IsInverted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Destinies", "IsInverted");
        }
    }
}
