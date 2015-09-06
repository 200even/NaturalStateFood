namespace NaturalState.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Membership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coops", "MembershipCost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coops", "MembershipCost");
        }
    }
}
