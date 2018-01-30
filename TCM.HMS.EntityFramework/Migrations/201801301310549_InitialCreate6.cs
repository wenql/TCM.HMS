namespace TCM.HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OpenId = c.String(),
                        NickName = c.String(),
                        Province = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        HeadImgUrl = c.String(),
                        UserName = c.String(),
                        Sex = c.Int(nullable: false),
                        BirthDay = c.String(),
                        Mobile = c.String(),
                        IdCard = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        PhysiqueScores = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
