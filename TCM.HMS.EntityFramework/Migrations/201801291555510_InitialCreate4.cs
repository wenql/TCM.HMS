namespace TCM.HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Physique_Document",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Zttz = c.String(),
                        Xttz = c.String(),
                        Cjbx = c.String(),
                        Xltz = c.String(),
                        Fbqx = c.String(),
                        Hjsy = c.String(),
                        Ydty = c.String(),
                        Tyff = c.String(),
                        Jksp = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Physique_Document");
        }
    }
}
