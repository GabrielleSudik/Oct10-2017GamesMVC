namespace Oct10_2017GamesMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTeamsReal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "Team", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "Team");
        }
    }
}
