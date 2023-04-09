namespace NotDefteri_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notebooktest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        NoteHeader = c.String(maxLength: 100),
                        NoteBody = c.String(storeType: "ntext"),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NoteID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lastname = c.String(),
                        UserName = c.String(maxLength: 15),
                        Password = c.String(maxLength: 10),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "UserID", "dbo.Users");
            DropIndex("dbo.Notes", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Notes");
        }
    }
}
