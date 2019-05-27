namespace IoTProject.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Arduinos", newName: "Arduinoes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Arduinoes", newName: "Arduinos");
        }
    }
}
