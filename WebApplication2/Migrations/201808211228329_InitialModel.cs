namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        DoctorCode = c.String(nullable: false, maxLength: 5),
                        NameAr = c.String(nullable: false, maxLength: 100),
                        NameEn = c.String(nullable: false, maxLength: 100),
                        SpecialtyId = c.Byte(nullable: false),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 1),
                        TickerPrice = c.Double(nullable: false),
                        AboutDoctorShortDescription = c.String(maxLength: 100),
                        AboutDoctorLongDescription = c.String(maxLength: 1000),
                        BirthDate = c.DateTime(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        SearchName = c.String(nullable: false, maxLength: 225),
                        CreatedBy = c.String(maxLength: 225),
                        CreadtedDateTime = c.DateTime(nullable: false),
                        ModifiedBy = c.String(maxLength: 225),
                        ModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctors");
        }
    }
}
