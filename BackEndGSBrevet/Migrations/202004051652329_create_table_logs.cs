namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_logs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "dbo.Log",
              l => new
              {
                  id = l.Int(nullable: false, identity: true),
                  created_at = l.DateTime(defaultValue: DateTime.Now),
                  activity_id = l.String(),
                  type = l.String(maxLength: 7),
                  username = l.String(),
                  message = l.String(),
                  passed_through = l.String()
              });
        }
        
        public override void Down()
        {
            DropTable("dbo.Log");
        }
    }
}
