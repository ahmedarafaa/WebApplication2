namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDocotorUserID2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "DoctorUserID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "DoctorUserID", c => c.Guid(nullable: false));
        }
    }
}
