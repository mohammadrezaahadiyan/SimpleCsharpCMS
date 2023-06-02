namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBaseMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "Posts.Post",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        PostTitle = c.String(),
                        PostDescription = c.String(),
                        Visit = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "Comments.Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        CommentText = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("Posts.Post", t => t.PostId)
                .Index(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Comments.Comment", "PostId", "Posts.Post");
            DropForeignKey("Posts.Post", "CategoryId", "dbo.Categories");
            DropIndex("Comments.Comment", new[] { "PostId" });
            DropIndex("Posts.Post", new[] { "CategoryId" });
            DropTable("Comments.Comment");
            DropTable("Posts.Post");
            DropTable("dbo.Categories");
        }
    }
}
