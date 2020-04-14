namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_roleId_to_users : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "role_id", c => c.Int());
            AddForeignKey("dbo.users", "role_id", "dbo.roles", "id");
        }
        
        public override void Down()
        {
        }
    }
}
