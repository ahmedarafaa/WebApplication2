namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDocotorUserID3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "DoctorCode", c => c.String(maxLength: 5));
            AlterColumn("dbo.Doctors", "NameAr", c => c.String(maxLength: 100));
            AlterColumn("dbo.Doctors", "NameEn", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "NameEn", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Doctors", "NameAr", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Doctors", "DoctorCode", c => c.String(nullable: false, maxLength: 5));
        }
    }
}
