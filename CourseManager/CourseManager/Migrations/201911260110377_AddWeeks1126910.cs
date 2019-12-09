namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeeks1126910 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Weeks", "WeekId", c => c.String());
            AlterColumn("dbo.Weeks", "SectionId", c => c.String());
            AlterColumn("dbo.Weeks", "CourseId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Weeks", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.Weeks", "SectionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Weeks", "WeekId", c => c.Int(nullable: false));
        }
    }
}
