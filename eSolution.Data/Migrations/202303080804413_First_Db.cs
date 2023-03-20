namespace eSolution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First_Db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Results",
               c => new
               {
                   ID = c.Int(nullable: false, identity: true),
                   PatientID = c.String(nullable: false, maxLength: 250, unicode: false),
                   Name = c.String(nullable: false, maxLength: 250),
                   Email = c.String(maxLength: 250),
                   TelephoneNumber = c.String(maxLength: 250),
                   QuestionNumbers = c.Int(nullable: false),
                   Result = c.String(maxLength: 500),
                   CreatedDate = c.DateTime(nullable: false),
               })
               .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
        }
    }
}
