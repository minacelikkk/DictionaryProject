namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "IsRead", c => c.Boolean(nullable: false));
            DropColumn("dbo.Messages", "IsDraft");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "IsDraft", c => c.Boolean(nullable: false));
            DropColumn("dbo.Messages", "IsRead");
        }
    }
}
