namespace TeamChallenge.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attempt50 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Post");
            CreateTable(
                "dbo.SocialMediaUser",
                c => new
                    {
                        SocialMediaUserId = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaUserId);
            
            AddColumn("dbo.Post", "PostId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Post", "Content", c => c.String(nullable: false));
            AddColumn("dbo.Post", "Author_SocialMediaUserId", c => c.Guid());
            AddPrimaryKey("dbo.Post", "PostId");
            CreateIndex("dbo.Post", "Author_SocialMediaUserId");
            AddForeignKey("dbo.Post", "Author_SocialMediaUserId", "dbo.SocialMediaUser", "SocialMediaUserId");
            DropColumn("dbo.Post", "Id");
            DropColumn("dbo.Post", "Text");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "Text", c => c.String(nullable: false));
            AddColumn("dbo.Post", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Post", "Author_SocialMediaUserId", "dbo.SocialMediaUser");
            DropIndex("dbo.Post", new[] { "Author_SocialMediaUserId" });
            DropPrimaryKey("dbo.Post");
            DropColumn("dbo.Post", "Author_SocialMediaUserId");
            DropColumn("dbo.Post", "Content");
            DropColumn("dbo.Post", "PostId");
            DropTable("dbo.SocialMediaUser");
            AddPrimaryKey("dbo.Post", "Id");
        }
    }
}
