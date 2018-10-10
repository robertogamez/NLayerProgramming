namespace PluralSightBookWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReferencesTables : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Friends", new[] { "UserId" });
            AlterColumn("dbo.Friends", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Friends", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Friends", new[] { "UserId" });
            AlterColumn("dbo.Friends", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Friends", "UserId");
        }
    }
}
