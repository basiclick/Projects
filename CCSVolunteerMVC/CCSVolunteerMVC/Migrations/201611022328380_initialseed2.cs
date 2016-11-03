namespace CCSVolunteerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialseed2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CompletedTraining", "cmpTrnComments", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CompletedTraining", "cmpTrnComments", c => c.String());
        }
    }
}
