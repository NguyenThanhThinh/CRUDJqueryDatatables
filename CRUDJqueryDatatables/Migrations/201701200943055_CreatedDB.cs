namespace CRUDJqueryDatatables.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                        EmailID = c.String(maxLength: 255),
                        City = c.String(maxLength: 255),
                        Country = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
