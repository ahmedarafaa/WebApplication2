namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDocotorUserID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "DoctorUserID", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "DoctorUserID");
        }
    }
}
