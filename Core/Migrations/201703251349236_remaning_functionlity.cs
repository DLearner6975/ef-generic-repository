namespace Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remaning_functionlity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Address = c.String(maxLength: 350),
                        Age = c.Int(nullable: false),
                        Designation = c.String(maxLength: 150),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
