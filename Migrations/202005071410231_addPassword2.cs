namespace ChatPusher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPassword2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "password");
        }
    }
}
