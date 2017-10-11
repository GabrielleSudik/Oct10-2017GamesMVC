namespace Oct10_2017GamesMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCrashes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "Crashes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "Crashes");
        }
    }
}
