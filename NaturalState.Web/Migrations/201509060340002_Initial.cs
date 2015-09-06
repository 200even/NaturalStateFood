namespace NaturalState.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Phone = c.String(),
                        Url = c.String(),
                        Email = c.String(),
                        MedianIncome = c.Double(nullable: false),
                        Population = c.Int(nullable: false),
                        IsOpen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Coops");
        }
    }
}
