namespace eSolution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Api_Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApiResponseResults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ResultID = c.Int(nullable: false),
                        PatientID = c.String(nullable: false, maxLength: 250, unicode: false),
                        Result = c.String(nullable: false, maxLength: 500),
                        Str1 = c.String(nullable: false, maxLength: 500),
                        Str2 = c.String(nullable: false, maxLength: 500),
                        Str3 = c.String(nullable: false, maxLength: 500),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApiResponseResults");
        }
    }
}
