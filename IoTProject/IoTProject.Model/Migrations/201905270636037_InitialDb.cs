namespace IoTProject.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Office = c.String(maxLength: 50),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.Arduinos",
                c => new
                    {
                        ArduinoID = c.Int(nullable: false, identity: true),
                        ADIndex = c.Int(nullable: false),
                        DataTime = c.DateTime(nullable: false),
                        Seq = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArduinoID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CaregoryID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CaregoryID);
            
            CreateTable(
                "dbo.CycleTimes",
                c => new
                    {
                        CycleTimeID = c.Int(nullable: false, identity: true),
                        RealTimeCycleTime = c.Double(),
                        AverageTimeCycleTime = c.Double(),
                    })
                .PrimaryKey(t => t.CycleTimeID);
            
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MaxCycleTimes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Station = c.String(maxLength: 10),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaxCycleTimes");
            DropTable("dbo.Errors");
            DropTable("dbo.CycleTimes");
            DropTable("dbo.Categories");
            DropTable("dbo.Arduinos");
            DropTable("dbo.Accounts");
        }
    }
}
