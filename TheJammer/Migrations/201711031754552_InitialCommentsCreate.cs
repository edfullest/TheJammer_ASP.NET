namespace TheJammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommentsCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CommentDate = c.DateTime(nullable: false),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "User_ID", "dbo.Users");
            DropIndex("dbo.Comments", new[] { "User_ID" });
            DropTable("dbo.Comments");
        }
    }
}
