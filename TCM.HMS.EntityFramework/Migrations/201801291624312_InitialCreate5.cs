namespace TCM.HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physique_Document", "Ywty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physique_Document", "Ywty");
        }
    }
}
