namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDocotorUserID1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Doctors", "SpecialtyId");
            DropColumn("dbo.Doctors", "CountryId");
            DropColumn("dbo.Doctors", "CityId");
            DropColumn("dbo.Doctors", "AreaId");
            DropColumn("dbo.Doctors", "Gender");
            DropColumn("dbo.Doctors", "TickerPrice");
            DropColumn("dbo.Doctors", "AboutDoctorShortDescription");
            DropColumn("dbo.Doctors", "AboutDoctorLongDescription");
            DropColumn("dbo.Doctors", "BirthDate");
            DropColumn("dbo.Doctors", "RegisterDate");
            DropColumn("dbo.Doctors", "SearchName");
            DropColumn("dbo.Doctors", "CreatedBy");
            DropColumn("dbo.Doctors", "CreadtedDateTime");
            DropColumn("dbo.Doctors", "ModifiedBy");
            DropColumn("dbo.Doctors", "ModifiedDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "ModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Doctors", "ModifiedBy", c => c.String(maxLength: 225));
            AddColumn("dbo.Doctors", "CreadtedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Doctors", "CreatedBy", c => c.String(maxLength: 225));
            AddColumn("dbo.Doctors", "SearchName", c => c.String(nullable: false, maxLength: 225));
            AddColumn("dbo.Doctors", "RegisterDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Doctors", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Doctors", "AboutDoctorLongDescription", c => c.String(maxLength: 1000));
            AddColumn("dbo.Doctors", "AboutDoctorShortDescription", c => c.String(maxLength: 100));
            AddColumn("dbo.Doctors", "TickerPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Doctors", "Gender", c => c.String(nullable: false, maxLength: 1));
            AddColumn("dbo.Doctors", "AreaId", c => c.Int(nullable: false));
            AddColumn("dbo.Doctors", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.Doctors", "CountryId", c => c.Int(nullable: false));
            AddColumn("dbo.Doctors", "SpecialtyId", c => c.Byte(nullable: false));
        }
    }
}
