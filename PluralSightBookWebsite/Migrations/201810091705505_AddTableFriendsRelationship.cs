namespace PluralSightBookWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableFriendsRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friends", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Friends", new[] { "UserId" });
            DropColumn("dbo.AspNetUsers", "Discriminator");
            DropTable("dbo.Friends");
        }
    }
}
