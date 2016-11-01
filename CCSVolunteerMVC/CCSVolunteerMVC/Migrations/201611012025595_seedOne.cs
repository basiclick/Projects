namespace CCSVolunteerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedOne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompletedTraining",
                c => new
                    {
                        completedTrainingID = c.Int(nullable: false, identity: true),
                        volID = c.Int(nullable: false),
                        volTrnID = c.Int(nullable: false),
                        cmpTrnDate = c.DateTime(nullable: false),
                        cmpTrnComments = c.String(),
                        volunteer_volunteerID = c.Int(),
                        volunteerTraining_volunteerTrainingID = c.Int(),
                    })
                .PrimaryKey(t => t.completedTrainingID)
                .ForeignKey("dbo.Volunteer", t => t.volunteer_volunteerID)
                .ForeignKey("dbo.VolunteerTraining", t => t.volunteerTraining_volunteerTrainingID)
                .Index(t => t.volunteer_volunteerID)
                .Index(t => t.volunteerTraining_volunteerTrainingID);
            
            CreateTable(
                "dbo.Volunteer",
                c => new
                    {
                        volunteerID = c.Int(nullable: false, identity: true),
                        volFirstName = c.String(),
                        volLastName = c.String(),
                        volDOB = c.DateTime(nullable: false),
                        volPin = c.Int(nullable: false),
                        volGender = c.String(),
                        volJoinDate = c.DateTime(nullable: false),
                        volsCourtOrdered = c.Int(nullable: false),
                        ethID = c.Int(),
                        volsClient = c.Byte(nullable: false),
                        volsActive = c.Byte(nullable: false),
                        ethnicity_ethnicityID = c.Int(),
                    })
                .PrimaryKey(t => t.volunteerID)
                .ForeignKey("dbo.Ethnicity", t => t.ethnicity_ethnicityID)
                .Index(t => t.ethnicity_ethnicityID);
            
            CreateTable(
                "dbo.CourtOrdered",
                c => new
                    {
                        courtOrderedID = c.Int(nullable: false, identity: true),
                        volID = c.Int(),
                        crtOrderCaseNumber = c.String(),
                        crtOrderedHoursRequired = c.Int(nullable: false),
                        crtOrderedStartDate = c.DateTime(nullable: false),
                        crtOrderedSexOrViolentCrime = c.Int(nullable: false),
                        crtOrderedOneMonthLimit = c.Int(nullable: false),
                        volunteer_volunteerID = c.Int(),
                    })
                .PrimaryKey(t => t.courtOrderedID)
                .ForeignKey("dbo.Volunteer", t => t.volunteer_volunteerID)
                .Index(t => t.volunteer_volunteerID);
            
            CreateTable(
                "dbo.Ethnicity",
                c => new
                    {
                        ethnicityID = c.Int(nullable: false, identity: true),
                        ethName = c.String(),
                    })
                .PrimaryKey(t => t.ethnicityID);
            
            CreateTable(
                "dbo.HoursWorked",
                c => new
                    {
                        hoursWorkedID = c.Int(nullable: false, identity: true),
                        posID = c.Int(nullable: false),
                        hrsWrkdIDType = c.String(),
                        hrsWrkdTimeIn = c.DateTime(nullable: false),
                        hrsWrkdTimeOut = c.DateTime(nullable: false),
                        userAcctID = c.Int(nullable: false),
                        modifiedOn = c.DateTime(nullable: false),
                        hrsWrkedSchedDate = c.DateTime(nullable: false),
                        volID = c.Int(nullable: false),
                        volGrpID = c.Int(nullable: false),
                        hrsWrkdQty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        positionLocation_positionLocationID = c.Int(),
                        volunteer_volunteerID = c.Int(),
                        VolunteerGroup_volunteerGroupID = c.Int(),
                    })
                .PrimaryKey(t => t.hoursWorkedID)
                .ForeignKey("dbo.PositionLocation", t => t.positionLocation_positionLocationID)
                .ForeignKey("dbo.Volunteer", t => t.volunteer_volunteerID)
                .ForeignKey("dbo.VolunteerGroup", t => t.VolunteerGroup_volunteerGroupID)
                .Index(t => t.positionLocation_positionLocationID)
                .Index(t => t.volunteer_volunteerID)
                .Index(t => t.VolunteerGroup_volunteerGroupID);
            
            CreateTable(
                "dbo.PositionLocation",
                c => new
                    {
                        positionLocationID = c.Int(nullable: false, identity: true),
                        posLocationName = c.String(),
                        posLocationStreet1 = c.String(),
                        posLocationStreet2 = c.String(),
                        posLocationCity = c.String(),
                        posLocationState = c.String(),
                        posLocationZip = c.String(),
                        posLocationNotes = c.String(),
                    })
                .PrimaryKey(t => t.positionLocationID);
            
            CreateTable(
                "dbo.VolunteerLanguage",
                c => new
                    {
                        volunteerLanguageID = c.Int(nullable: false, identity: true),
                        volunteerID = c.Int(nullable: false),
                        foreignLanguageID = c.Int(nullable: false),
                        volLangFluencyLvl = c.Short(nullable: false),
                        volLangLiteracyLvl = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.volunteerLanguageID)
                .ForeignKey("dbo.ForeignLanguage", t => t.foreignLanguageID, cascadeDelete: true)
                .ForeignKey("dbo.Volunteer", t => t.volunteerID, cascadeDelete: true)
                .Index(t => t.volunteerID)
                .Index(t => t.foreignLanguageID);
            
            CreateTable(
                "dbo.ForeignLanguage",
                c => new
                    {
                        foreignLanguageID = c.Int(nullable: false, identity: true),
                        foreignLangName = c.String(),
                    })
                .PrimaryKey(t => t.foreignLanguageID);
            
            CreateTable(
                "dbo.VolunteerTraining",
                c => new
                    {
                        volunteerTrainingID = c.Int(nullable: false, identity: true),
                        volTrnName = c.String(),
                        volTrnDesc = c.String(),
                        volTrnCCSRequired = c.Int(nullable: false),
                        volTrnStateRequired = c.Int(nullable: false),
                        volTrnMonthsValid = c.Short(nullable: false),
                        volTrnBackgroundLvl = c.Short(nullable: false),
                        volTrnMVR = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.volunteerTrainingID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        contactID = c.Int(nullable: false, identity: true),
                        contTypeID = c.Int(nullable: false),
                        volID = c.Int(),
                        contactInfo = c.String(),
                        contCanContact = c.Int(nullable: false),
                        volunteer_volunteerID = c.Int(),
                        ContactType_contactTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.contactID)
                .ForeignKey("dbo.Volunteer", t => t.volunteer_volunteerID)
                .ForeignKey("dbo.ContactType", t => t.ContactType_contactTypeID)
                .Index(t => t.volunteer_volunteerID)
                .Index(t => t.ContactType_contactTypeID);
            
            CreateTable(
                "dbo.ContactType",
                c => new
                    {
                        contactTypeID = c.Int(nullable: false, identity: true),
                        contTypeName = c.String(),
                    })
                .PrimaryKey(t => t.contactTypeID);
            
            CreateTable(
                "dbo.GroupContact",
                c => new
                    {
                        groupContactID = c.Int(nullable: false, identity: true),
                        grpContName = c.String(),
                        contTypeID = c.Int(nullable: false),
                        volGroupID = c.Int(),
                        grpContInfo = c.String(),
                        contactType_contactTypeID = c.Int(),
                        volunteerGroup_volunteerGroupID = c.Int(),
                    })
                .PrimaryKey(t => t.groupContactID)
                .ForeignKey("dbo.ContactType", t => t.contactType_contactTypeID)
                .ForeignKey("dbo.VolunteerGroup", t => t.volunteerGroup_volunteerGroupID)
                .Index(t => t.contactType_contactTypeID)
                .Index(t => t.volunteerGroup_volunteerGroupID);
            
            CreateTable(
                "dbo.VolunteerGroup",
                c => new
                    {
                        volunteerGroupID = c.Int(nullable: false, identity: true),
                        volGrpName = c.String(),
                        volGrpUserName = c.String(),
                        volGrpPasswordHash = c.String(),
                        volGrpAddress1 = c.String(),
                        volGrpAddress2 = c.String(),
                        volGrpState = c.String(),
                        volGrpZip = c.String(),
                        volGrpIsActive = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.volunteerGroupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoursWorked", "VolunteerGroup_volunteerGroupID", "dbo.VolunteerGroup");
            DropForeignKey("dbo.GroupContact", "volunteerGroup_volunteerGroupID", "dbo.VolunteerGroup");
            DropForeignKey("dbo.GroupContact", "contactType_contactTypeID", "dbo.ContactType");
            DropForeignKey("dbo.Contact", "ContactType_contactTypeID", "dbo.ContactType");
            DropForeignKey("dbo.Contact", "volunteer_volunteerID", "dbo.Volunteer");
            DropForeignKey("dbo.CompletedTraining", "volunteerTraining_volunteerTrainingID", "dbo.VolunteerTraining");
            DropForeignKey("dbo.VolunteerLanguage", "volunteerID", "dbo.Volunteer");
            DropForeignKey("dbo.VolunteerLanguage", "foreignLanguageID", "dbo.ForeignLanguage");
            DropForeignKey("dbo.HoursWorked", "volunteer_volunteerID", "dbo.Volunteer");
            DropForeignKey("dbo.HoursWorked", "positionLocation_positionLocationID", "dbo.PositionLocation");
            DropForeignKey("dbo.Volunteer", "ethnicity_ethnicityID", "dbo.Ethnicity");
            DropForeignKey("dbo.CourtOrdered", "volunteer_volunteerID", "dbo.Volunteer");
            DropForeignKey("dbo.CompletedTraining", "volunteer_volunteerID", "dbo.Volunteer");
            DropIndex("dbo.GroupContact", new[] { "volunteerGroup_volunteerGroupID" });
            DropIndex("dbo.GroupContact", new[] { "contactType_contactTypeID" });
            DropIndex("dbo.Contact", new[] { "ContactType_contactTypeID" });
            DropIndex("dbo.Contact", new[] { "volunteer_volunteerID" });
            DropIndex("dbo.VolunteerLanguage", new[] { "foreignLanguageID" });
            DropIndex("dbo.VolunteerLanguage", new[] { "volunteerID" });
            DropIndex("dbo.HoursWorked", new[] { "VolunteerGroup_volunteerGroupID" });
            DropIndex("dbo.HoursWorked", new[] { "volunteer_volunteerID" });
            DropIndex("dbo.HoursWorked", new[] { "positionLocation_positionLocationID" });
            DropIndex("dbo.CourtOrdered", new[] { "volunteer_volunteerID" });
            DropIndex("dbo.Volunteer", new[] { "ethnicity_ethnicityID" });
            DropIndex("dbo.CompletedTraining", new[] { "volunteerTraining_volunteerTrainingID" });
            DropIndex("dbo.CompletedTraining", new[] { "volunteer_volunteerID" });
            DropTable("dbo.VolunteerGroup");
            DropTable("dbo.GroupContact");
            DropTable("dbo.ContactType");
            DropTable("dbo.Contact");
            DropTable("dbo.VolunteerTraining");
            DropTable("dbo.ForeignLanguage");
            DropTable("dbo.VolunteerLanguage");
            DropTable("dbo.PositionLocation");
            DropTable("dbo.HoursWorked");
            DropTable("dbo.Ethnicity");
            DropTable("dbo.CourtOrdered");
            DropTable("dbo.Volunteer");
            DropTable("dbo.CompletedTraining");
        }
    }
}
