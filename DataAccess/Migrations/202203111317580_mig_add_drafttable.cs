namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_drafttable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drafts",
                c => new
                    {
                        DraftId = c.Int(nullable: false, identity: true),
                        Subject = c.String(maxLength: 50),
                        ReceiverMail = c.String(maxLength: 50),
                        DraftContent = c.String(maxLength: 30),
                        DraftDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DraftId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drafts");
        }
    }
}
