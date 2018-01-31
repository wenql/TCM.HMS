namespace TCM.HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physique_Subject", "OnlySex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physique_Subject", "OnlySex");
        }
    }
}
