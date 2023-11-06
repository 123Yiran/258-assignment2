namespace assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagePathToDestiny : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Destinies", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Destinies", "ImagePath");
        }
    }
}
