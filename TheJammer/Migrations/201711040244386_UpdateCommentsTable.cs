namespace TheJammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCommentsTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Comments", name: "User_ID", newName: "UserID");
            RenameIndex(table: "dbo.Comments", name: "IX_User_ID", newName: "IX_UserID");
            DropColumn("dbo.Comments", "StatusID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "StatusID", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Comments", name: "IX_UserID", newName: "IX_User_ID");
            RenameColumn(table: "dbo.Comments", name: "UserID", newName: "User_ID");
        }
    }
}
