namespace TCM.HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Physique_SubjectOption", "SubjectId", "dbo.Physique_Subject");
            DropIndex("dbo.Physique_SubjectOption", new[] { "SubjectId" });
            AddColumn("dbo.Physique_Subject", "Scores", c => c.String());
            DropTable("dbo.Physique_SubjectOption");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Physique_SubjectOption",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        Title = c.String(),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Physique_Subject", "Scores");
            CreateIndex("dbo.Physique_SubjectOption", "SubjectId");
            AddForeignKey("dbo.Physique_SubjectOption", "SubjectId", "dbo.Physique_Subject", "Id", cascadeDelete: true);
        }
    }
}
