namespace assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCharacterProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "Faction", c => c.String());
            AddColumn("dbo.Characters", "Attribute", c => c.String());
            AddColumn("dbo.Characters", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "ImagePath");
            DropColumn("dbo.Characters", "Attribute");
            DropColumn("dbo.Characters", "Faction");
        }
    }
}
